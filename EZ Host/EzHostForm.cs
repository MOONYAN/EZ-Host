using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Web.Script.Serialization;
using EZ_Host.FireField;
using ZXing;
using ZXing.QrCode;
using System.IO.Ports;
using EZ_Host.ComField;
using System.Net.Sockets;

namespace EZ_Host
{
    public partial class EzHostForm : Form
    {
        private Server _server;
        private Thread _serverThread;
        private JavaScriptSerializer _javaScriptSerializer;

        public EzHostForm()
        {
            InitializeComponent();
            _javaScriptSerializer = new JavaScriptSerializer();
            _server = new Server();
            _serverThread = new Thread(_server.StartListening);
            //_serverThread.IsBackground = true;
        }

        private void EzHostForm_Load(object sender, EventArgs e)
        {
            _server._receiveRequestEvent += HandleReceiveRequest;
            _server._compareResultEvent += HandleCompareResult;
            _serverGroupBox.DataBindings.Add("Text", _server, "ServerIP");
            InitializeQR();
            _portComboBox.DataSource = SerialPort.GetPortNames();
            _serverThread.Start();
        }

        private void HandleCompareResult(string message)
        {
            this.Invoke(new Action(() => _stateLabel.Text = message));
        }

        private void InitializeQR()
        {
            var writer = new BarcodeWriter()
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Height = 300,
                    Width = 300
                }
            };
            _qrPictureBox.Image = writer.Write(_server.ServerIP);
        }

        private void HandleReceiveRequest(FireRecord record)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => _clientDataGridView.DataSource = record.Cart.ItemList));
            }
        }

        private void _openPortButton_Click(object sender, EventArgs e)
        {
            _serialPort.PortName = _portComboBox.Text;
            _serialPort.Open();
            Console.WriteLine(_serialPort.PortName + " is opened");
            _openPortButton.Enabled = false;
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new Action(() => _clientDataGridView.DataSource = null));
            this.Invoke(new Action(() => _rfidDataGridView.DataSource = null));
            _server.ComItemList = null;
            Thread.Sleep(100);
            string json = _serialPort.ReadExisting();
            List<ComItem> list = _javaScriptSerializer.Deserialize<List<ComItem>>(json);
            _server.ComItemList = list;
            this.Invoke(new Action(() => _rfidDataGridView.DataSource = list));
            Console.WriteLine(list.Count);
        }
    }
}
