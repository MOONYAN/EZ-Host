using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EZ_Host
{
    // State object for reading client data asynchronously
    class StateObject
    {
        // Client  socket.
        public Socket _workSocket = null;
        // Size of receive buffer.
        public const int BUFFER_SIZE = 1024;
        // Receive buffer.
        public byte[] _buffer = new byte[BUFFER_SIZE];
        // Received data string.
        public StringBuilder _stringBuilder = new StringBuilder();
    }
}
