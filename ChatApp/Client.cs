using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ChatApp
{
    public class Client
    {

        public List<String> Messages = new List<String>();
        private Socket _sck;
        private EndPoint _epLocal;
        private EndPoint _epRemote;
        private byte[] _buffer;
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


        public Client(string ownIP, int ownPort, string remoteIP, int remotePort)
        {

            _sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            _epLocal = new IPEndPoint(IPAddress.Parse(ownIP), ownPort);
            _sck.Bind(_epLocal);
            _epRemote = new IPEndPoint(IPAddress.Parse(remoteIP), remotePort);
            _sck.Connect(_epRemote);
            _buffer = new byte[1500];
            _sck.BeginReceiveFrom(_buffer, 0, _buffer.Length, SocketFlags.None, ref _epRemote, new AsyncCallback(MessageCallBack), _buffer);

        }

        public byte[] SendMeessage(string message)
        {
            ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
            byte[] sendingMessages = new byte[1500];
            sendingMessages = aSCIIEncoding.GetBytes(message);
            _sck.Send(sendingMessages);
            return sendingMessages;
        }


        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;
                ASCIIEncoding sCIIEncoding = new ASCIIEncoding();
                string receivedMessage = sCIIEncoding.GetString(receivedData);
                Messages.Add("Friend: " + receivedMessage);
                _sck.BeginReceiveFrom(_buffer, 0, _buffer.Length, SocketFlags.None, ref _epRemote, new AsyncCallback(MessageCallBack), _buffer);

            }
            catch (Exception ex)
            {

            }

        }


    }
}
