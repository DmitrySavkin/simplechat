using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class Form1 : Form
    {
       

        public List<String> Messages = new List<String>();
        private Socket _sck;
        private EndPoint _epLocal;
        private EndPoint _epRemote;
        private byte[] _buffer;
        private bool _start = false;
        public static string IP
        {
            get
            {
                IPHostEntry host;
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }

                return "127.0.0.1";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (!_start)
            {
                try
                {
                    int portOwn = Convert.ToInt32(portOwnTextBox.Text);
                    int portRemote = Convert.ToInt32(portBoxRemote.Text);


                    _sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    _sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                    _epLocal = new IPEndPoint(IPAddress.Parse(ipOwnTextBox.Text), portOwn);
                    _sck.Bind(_epLocal);
                    _epRemote = new IPEndPoint(IPAddress.Parse(ipBoxRemote.Text), portRemote);
                    _sck.Connect(_epRemote);
                    _buffer = new byte[1500];
                    _sck.BeginReceiveFrom(_buffer, 0, _buffer.Length, SocketFlags.None, ref _epRemote, new AsyncCallback(MessageCallBack), _buffer);

                    startBtn.Text = "Stop";
                    _start = true;
                }
                catch (FormatException ex){
                    MessageBox.Show("Port is invalid");
                }
            } else
            {

                _start = false;
                startBtn.Text = "Start";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ipOwnTextBox.Text =IP;
            ipBoxRemote.Text = IP;
            startBtn.Text = "Start" ;
        }

       

        private void sendBtn_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
            byte[] sendingMessages = new byte[1500];
            sendingMessages = aSCIIEncoding.GetBytes(outgoingMessage.Text);
            _sck.Send(sendingMessages);
            listMessages.Items.Add("Me " + outgoingMessage.Text);
        }

        public void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;
                ASCIIEncoding sCIIEncoding = new ASCIIEncoding();
                string receivedMessage = sCIIEncoding.GetString(receivedData);
                listMessages.Items.Add("Friend: " + receivedMessage);
                _sck.BeginReceiveFrom(_buffer, 0, _buffer.Length, SocketFlags.None, ref _epRemote, new AsyncCallback(MessageCallBack), _buffer);

            }
            catch (Exception ex)
            {

            }

        }


    }
}
