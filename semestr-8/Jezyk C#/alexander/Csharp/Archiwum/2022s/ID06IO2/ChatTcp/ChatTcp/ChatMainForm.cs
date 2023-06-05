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

namespace ChatTcp
{
    public partial class ChatMainForm : Form
    {
        private delegate void AppendLogProc(string message);
        private TcpClient client=null;
        private TcpListener server = null;
        private bool active=false;
        private List<Socket> sockets = new List<Socket>();

        public ChatMainForm()
        {
            InitializeComponent();
        }

        /*
        private void AppendLog(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new AppendLogProc(AppendLog), new object[] { message });
            }
            else TbLog.AppendText(message + Environment.NewLine);
        }
        */
        private void AppendLog(string message)
        {
            TbLog.AppendText(message + Environment.NewLine);
        }

        private void AppendLogIvoke(string message)
        {
            Invoke(new AppendLogProc(AppendLog), new object[] { message });
        }

        private void ClientMainLoop()
        {
            client = new TcpClient("localhost", 6688);
            AppendLogIvoke("Client connected");
            try
            {
                active = true;
                while (active)
                {
                    if (client.Client.Poll(100, SelectMode.SelectRead))
                    {
                        int size = client.Client.Available;
                        if (size <= 0) break;
                        byte[] buffer = new byte[size];
                        client.Client.Receive(buffer);
                        string message = UTF8Encoding.UTF8.GetString(buffer);
                        AppendLogIvoke(message);
                    }
                    else Thread.Sleep(10);
                }
            }
            catch(Exception ex)
            {
            }
            client.Close();
            active = false;
            AppendLogIvoke("Client disconnected");
            client = null;
        }

        private void ServerClientLoop(Socket socket)
        {
            sockets.Add(socket);
            string who = socket.RemoteEndPoint.ToString();
            while (active)
            {
                if (socket.Poll(100, SelectMode.SelectRead))
                {
                    int size = socket.Available;
                    if (size <= 0) break;
                    byte[] buffer = new byte[size];
                    socket.Receive(buffer);
                    string message = who + ": " + UTF8Encoding.UTF8.GetString(buffer);
                    buffer = UTF8Encoding.UTF8.GetBytes(message);
                    foreach (Socket sock in sockets) sock.Send(buffer);
                    AppendLogIvoke(message);
                }
            }
            sockets.Remove(socket);
            socket.Close();
        }

        private void ServerMainLoop()
        {
            AppendLogIvoke("Server started");
            server = new TcpListener(IPAddress.Any, 6688);
            active = true;
            server.Start();
            while (active)
            {
                if (server.Pending())
                {
                    new Thread(() => ServerClientLoop(server.AcceptSocket())).Start();
                }
                else Thread.Sleep(10);
            }
            server.Stop();
            server = null;
            AppendLogIvoke("Server stopped");
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            new Thread(() => ClientMainLoop()).Start();
        }

        private void BtnServer_Click(object sender, EventArgs e)
        {
            new Thread(() => ServerMainLoop()).Start();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if(client!=null)
            {
                byte[] buffer=UTF8Encoding.UTF8.GetBytes(TbMessage.Text);
                client.Client.Send(buffer);
            }
        }

        private void ChatMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            active = false;
            //while (client != null || server != null) Thread.Sleep(100);
        }
    }
}
