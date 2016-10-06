using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EZ_Host.ComField;
using EZ_Host.FireField;

namespace EZ_Host
{
    class Server : INotifyPropertyChanged
    {
        //private JavaScriptSerializer _javaScriptSerializer;
        private ManualResetEvent _manualResetEvent;
        private String _serverIP = "Server IP = none set";
        public delegate void ReceiveRequestHandler(FireRecord record);
        public event ReceiveRequestHandler _receiveRequestEvent;
        public event PropertyChangedEventHandler PropertyChanged;
        private IPEndPoint _localEndPoint;
        private JavaScriptSerializer _javaScriptSerializer;
        public List<ComItem> ComItemList { get; set; }

        public Server()
        {
            //_javaScriptSerializer = new JavaScriptSerializer();
            _manualResetEvent = new ManualResetEvent(false);

            const int PORT = 11000;
            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            IPAddress iPAddress = ipHostInfo.AddressList[1];
            ServerIP = iPAddress.ToString();
            _localEndPoint = new IPEndPoint(iPAddress, PORT);
            Console.WriteLine("server ip is :" + iPAddress.ToString());
            //StartListening();
        }

        public void StartListening()
        {
            //const int PORT = 11000;
            //IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            //IPAddress iPAddress = ipHostInfo.AddressList[0];
            //ServerIP = "Server IP = "  +iPAddress.ToString();
            //IPEndPoint localEndPoint = new IPEndPoint(iPAddress, PORT);
            //Console.WriteLine("server ip is :" + iPAddress.ToString());
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and listen for incoming connections.
            try
            {
                const int BACKLOG = 100;
                listener.Bind(_localEndPoint);
                listener.Listen(BACKLOG);
                while (true)
                {
                    // Set the event to nonsignaled state.
                    _manualResetEvent.Reset();

                    // Start an asynchronous socket to listen for connections.
                    Console.WriteLine("Waiting for a connection...");
                    listener.BeginAccept(AcceptCallback, listener);

                    // Wait until a connection is made before continuing.
                    _manualResetEvent.WaitOne();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            // Signal the main thread to continue.
            _manualResetEvent.Set();
            // Get the socket that handles the client request.
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            // Create the state object.
            StateObject state = new StateObject();
            state._workSocket = handler;
            handler.BeginReceive(state._buffer, 0, StateObject.BUFFER_SIZE, 0, ReadCallback, state);
        }

        private void ReadCallback(IAsyncResult ar)
        {
            String content = string.Empty;

            // Retrieve the state object and the handler socket
            // from the asynchronous state object.
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state._workSocket;

            // Read data from the client socket.
            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                // There  might be more data, so store the data received so far.
                state._stringBuilder.Append(Encoding.ASCII.GetString(state._buffer, 0, bytesRead));

                // Check for end-of-file tag. If it is not there, read more data.
                content = state._stringBuilder.ToString();

                Console.WriteLine("Read {0} bytes from socket. \n Data : {1}", content.Length, content);
                FireRecord record = _javaScriptSerializer.Deserialize<FireRecord>(content);
                NotifyReceiveRequestEvent(record);

                //HandleComparison(handler, record.Cart.ItemList);
                //Person person = _serializer.Deserialize<Person>(content);
                Send(handler, "Success");
            }
        }

        private void HandleComparison(Socket handler, List<FireItem> itemList)
        {
            if (ComItemList != null && ComItemList.Count == itemList.Count)
            {
                List<ComItem> clientList = itemList.Select(e => new ComItem() { Count = e.Count, Id = e.ProductId }).ToList();
                clientList.Sort();
                ComItemList.Sort();
                for (int i = 0; i < clientList.Count; i++)
                {
                    if(clientList[i].Id != ComItemList[i].Id || clientList[i].Count != ComItemList[i].Count )
                    {
                        Send(handler, "has not read rfid");
                        return;
                    }
                }
                Send(handler, "Success");
                return;
            }
            Send(handler, "has not read rfid");
        }

        private void Send(Socket handler, string data)
        {
            // Convert the string data to byte data using ASCII encoding.
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.
            handler.BeginSend(byteData, 0, byteData.Length, 0, SendCallback, handler);
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void NotifyReceiveRequestEvent(FireRecord record)
        {
            _receiveRequestEvent?.Invoke(record);
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string ServerIP
        {
            get
            {
                return _serverIP;
            }
            private set
            {
                _serverIP = value;
                NotifyPropertyChanged();
            }
        }
    }
}