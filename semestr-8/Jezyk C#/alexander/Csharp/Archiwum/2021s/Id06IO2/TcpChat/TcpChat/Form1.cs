using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace TcpChat
{
    public partial class TCPchat : Form
    {
        private delegate void AppendLogProc(string message);
        private UInt16 port = 8881;
        private TcpListener server;
        private TcpClient client;
        private List<Socket> clients=new List<Socket>();
        private bool active;
        public TCPchat()
        {
            InitializeComponent();
            TxtPort.Text = port.ToString();
            AdjustControl();
        }

        private void AppendLog(string message)
        {
            if(InvokeRequired) Invoke(new AppendLogProc(AppendLog), message);
            else TxtLog.AppendText(message + Environment.NewLine);
        }

        private void AdjustControl()
        {
            string message = TxtMessage.Text.Trim();

            bool MessageNotEmpty = (message.Length > 0);

            BtnSend.Enabled = (MessageNotEmpty);
            BtnConnect.Enabled = UInt16.TryParse(TxtPort.Text, out port);
            if(active) BtnConnect.Text = "Disconnect";
            else BtnConnect.Text = "Connect";
        }

        private void ClientTalk()
        {
            Socket socket = server.AcceptSocket();
            string who = socket.RemoteEndPoint.ToString();
            AppendLog(who+": connected");
            clients.Add(socket);
            while(active)
            {
                if(socket.Poll(50000,SelectMode.SelectRead))
                {
                    int size = socket.Available;
                    if (size <= 0) break;
                    byte[] buff = new byte[size];
                    socket.Receive(buff);
                    string message = who+": "+UTF8Encoding.UTF8.GetString(buff);
                    buff=UTF8Encoding.UTF8.GetBytes(message);
                    foreach(Socket sock in clients) sock.Send(buff);
                    AppendLog(message);
                }
            }
            AppendLog(who + ": disconnected");
            clients.Remove(socket);
        }

        private void ServerLoop()
        {
            server = new TcpListener(IPAddress.Any,port);
            server.Start();
            AppendLog("Server connected");
            AdjustControl();
            active = true;
            while(active)
            {
                if(server.Pending()) new Thread(ClientTalk).Start();
            }
            server.Stop();
            AppendLog("Server disconnected");
            AdjustControl();
        }

        private void ClientLoop()
        {
            client = new TcpClient(TxtHost.Text, port);
            Socket socket = client.Client;
            AppendLog("Connected");
            active = true;
            while (active)
            {
                if (socket.Poll(50000, SelectMode.SelectRead))
                {
                    int size = socket.Available;
                    if (size <= 0) break;
                    byte[] buff = new byte[size];
                    socket.Receive(buff);
                    string message = UTF8Encoding.UTF8.GetString(buff);
                    AppendLog(message);
                }
            }
            AppendLog("Disconnected");
        }

        private void TxtPort_TextChanged(object sender, EventArgs e)
        {
            AdjustControl();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if(active)
            {
                active = false;
            }
            else
            {
                if(ChkServer.Checked) new Thread(ServerLoop).Start();
                else new Thread(ClientLoop).Start();
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (ChkServer.Checked)
            {

            }
            else client.Client.Send(UTF8Encoding.UTF8.GetBytes(TxtMessage.Text.Trim()));
        }

        private void TxtMessage_TextChanged(object sender, EventArgs e)
        {
            AdjustControl();
        }

        private void TCPchat_FormClosing(object sender, FormClosingEventArgs e)
        {
            active = false;
        }
    }
}
