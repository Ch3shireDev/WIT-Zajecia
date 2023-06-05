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
using System.Net;
using System.Net.Sockets;

namespace TcpChat
{
    public partial class Form1 : Form
    {
        private delegate void AppendLogProc(string message);
        private TcpListener server;
        private TcpClient client;
        private List<Socket> clients = new List<Socket>();
        private UInt16 port=8881;
        private bool active;
        public Form1()
        {
            InitializeComponent();
            TxtPort.Text = port.ToString();
        }

        private void AppendLog(string message)
        {
            if (InvokeRequired) Invoke(new AppendLogProc(AppendLog), message);
            else TxtLog.AppendText(message + Environment.NewLine);
        }

        private void SetActive(bool active)
        {
            this.active = active;
        }

        private void ClientThread()
        {
            client = new TcpClient(TxtHost.Text.Trim(), port);
            Socket socket = client.Client;
            SetActive(true);
            while (active)
            {
                if (socket.Poll(50000, SelectMode.SelectRead))
                {
                    int size = socket.Available;
                    if (size <= 0) break;
                    byte[] buffer = new byte[size];
                    socket.Receive(buffer);
                    string message = UTF8Encoding.UTF8.GetString(buffer);
                    AppendLog(message);
                }
            }
            SetActive(false);
            socket.Disconnect(true);
        }
        private void ServerClientThread()
        {
            Socket socket = server.AcceptSocket();
            string who = socket.RemoteEndPoint.ToString();
            clients.Add(socket);
            while (active)
            {
                if(socket.Poll(50000,SelectMode.SelectRead))
                {
                    int size = socket.Available;
                    if (size <= 0) break;
                    byte[] buffer = new byte[size];
                    socket.Receive(buffer);
                    string message = who + ": " + UTF8Encoding.UTF8.GetString(buffer);
                    buffer = UTF8Encoding.UTF8.GetBytes(message);
                    foreach (Socket s in clients) s.Send(buffer);
                    AppendLog(message);
                }
            }
            clients.Remove(socket);
            socket.Disconnect(true);
        }
        private void ServerThread()
        {
            server = new TcpListener(IPAddress.Any, port);
            server.Start();
            SetActive(true);
            while (active)
            {
                if (server.Pending()) new Thread(ServerClientThread).Start();
            }
            SetActive(false);
            server.Stop();
        }

        private void TxtPort_TextChanged(object sender, EventArgs e)
        {
            BtnConnect.Enabled = UInt16.TryParse(TxtPort.Text, out port);
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (active) active = false;
            else if (ChkServer.Checked) new Thread(ServerThread).Start();
            else new Thread(ClientThread).Start();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string mesasage = TxtMessage.Text.Trim();
            if (ChkServer.Checked)
            {
                byte[] buffer = UTF8Encoding.UTF8.GetBytes("Server: " + mesasage);
                foreach (Socket s in clients) s.Send(buffer);
            }
            else
            {
                client.Client.Send(UTF8Encoding.UTF8.GetBytes(mesasage));
            }
        }
    }
}
