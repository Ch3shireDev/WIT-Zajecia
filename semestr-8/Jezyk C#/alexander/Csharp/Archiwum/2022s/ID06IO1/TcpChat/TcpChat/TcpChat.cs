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
    public partial class TcpChat : Form
    {
        private delegate void AppendLogProc(string message);
        private delegate void AdjustButtonsProc();
        private int port = 6688;
        private bool alive=false;
        private List<Socket> clients = new List<Socket>();
        private TcpListener server = null;
        private TcpClient client = null;
        public TcpChat()
        {
            InitializeComponent();
            AdjustButtons();
        }

        private void AdjustButtons()
        {
            BtnConnect.Text = alive? "Disconnect":"Connect";
            BtnSend.Enabled = alive;
            TbMessage.Enabled = alive;
            TbHost.Enabled = !CkbServer.Checked;
            if(alive)
            {
                CancelButton = BtnConnect;
                AcceptButton = BtnSend;
            }
            else
            {
                AcceptButton = BtnConnect;
                CancelButton = null;
            }
        }

        private void AdjustButtonsInvoke()
        {
            if(alive) Invoke(new AdjustButtonsProc(AdjustButtons));
        }

        private void AppendLog(string message)
        {
            TbLog.AppendText(message + Environment.NewLine);
        }

        private void AppendLogInvoke(string message)
        {
            Invoke(new AppendLogProc(AppendLog), message);
        }

        private void ClientMainLoop()
        {
            try
            {
                client = new TcpClient(TbHost.Text, port);
                Socket socket = client.Client;
                AppendLogInvoke("Connected to server");
                alive = true;
                AdjustButtonsInvoke();
                while(alive)
                {
                    if (socket.Poll(10, SelectMode.SelectRead))
                    {
                        int size = socket.Available;
                        byte[] buffer = new byte[size];
                        socket.Receive(buffer);
                        string message = UTF8Encoding.UTF8.GetString(buffer);
                        AppendLogInvoke(message);
                    }
                }
                alive = false;
                AppendLogInvoke("Disconnected from server");
                client.Close();
                client = null;
                AdjustButtonsInvoke();
            }
            catch (Exception ex) { }
        }

        private void ServerClientLoop(Socket socket)
        {
            string Who = socket.RemoteEndPoint.ToString();
            lock (clients) clients.Add(socket);
            AppendLogInvoke(Who + ": connected");
            while(alive)
            {
                if(socket.Poll(10,SelectMode.SelectRead))
                {
                    int size = socket.Available;
                    byte[] buffer = new byte[size];
                    socket.Receive(buffer);
                    string message = Who+": "+ UTF8Encoding.UTF8.GetString(buffer);
                    AppendLogInvoke(message);
                    buffer = UTF8Encoding.UTF8.GetBytes(message);
                    lock (clients) foreach (Socket sock in clients) sock.Send(buffer);
                }
            }
            AppendLogInvoke(Who + ": disconnected");
            socket.Close();
            lock (clients) clients.Remove(socket);
        }

        private void ServerMainLoop()
        {
            try
            {
                server = new TcpListener(IPAddress.Any, port);
                server.Start();
                alive = true;
                AdjustButtonsInvoke();
                AppendLogInvoke("Server started");
                try
                {
                    while(alive)
                    {
                        if (server.Pending())
                        {
                            new Thread(() => ServerClientLoop(server.AcceptSocket())).Start();
                        }
                        else Thread.Sleep(10);
                    }
                }
                catch (Exception ex) { }
                alive = false;
                AppendLogInvoke("Server stopped");
                server.Stop();
                server = null;
                AdjustButtonsInvoke();
            }
            catch (Exception ex) {}
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (alive) alive = false;
            else if (CkbServer.Checked) new Thread(() => ServerMainLoop()).Start();
            else new Thread(() => ClientMainLoop()).Start();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string message = TbMessage.Text;
            if (CkbServer.Checked)
            {
                message = "Server: " + message;
                byte[] buffer = UTF8Encoding.UTF8.GetBytes(message);
                AppendLog(message);
                lock(clients) foreach (Socket sock in clients) sock.Send(buffer);
            }
            else
            {
                byte[] buffer = UTF8Encoding.UTF8.GetBytes(message);
                client.Client.Send(buffer);
            }
            TbMessage.SelectAll();
        }

        private void CkbServer_CheckedChanged(object sender, EventArgs e)
        {
            AdjustButtons();
        }

        private void TcpChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            alive = false;            
        }
    }
}
