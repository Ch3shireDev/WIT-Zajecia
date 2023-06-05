using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks; //
using System.Windows.Forms;
using System.Net; //
using System.Net.Sockets; //



namespace TcpChat
{
    public partial class TcpChatForm : Form
    {
        private static readonly int defaultPort = 6688;
        private Socket socket;
        private bool closing = false;
        private bool working = false;
        private List<Socket> clients = new List<Socket>();
        public TcpChatForm()
        {
            InitializeComponent();
        }
        delegate void AppendLogFunc(string text);
        private void AppendLog(string text)
        {
            if (!InvokeRequired) EdLog.AppendText(text + Environment.NewLine);
            else if (!closing) Invoke(new AppendLogFunc(AppendLog), new Object[] { text });
        }
        private int getPort()
        {
            int port = defaultPort;
            int.TryParse(EdPort.Text, out port);
            EdPort.Text = port.ToString();
            return port;
        }
        private void ClientCall(Socket socket)
        {
            try
            {
                AppendLog("Client Connected: " + socket.RemoteEndPoint);
                lock (clients) { clients.Add(socket); }
                while (working)
                {
                    if (socket.Poll(100, SelectMode.SelectRead))
                    {
                        int size = socket.Available;
                        if (size == 0) break;
                        byte[] buffer = new byte[size];
                        socket.Receive(buffer);
                        string message = socket.RemoteEndPoint.ToString() + ": " + UTF8Encoding.UTF8.GetString(buffer);
                        AppendLog(message);
                        buffer = UTF8Encoding.UTF8.GetBytes(message);
                        lock (clients) { foreach (Socket tmp in clients) tmp.Send(buffer); }
                    }
                }
            }
            catch (Exception) { }
            lock (clients) { clients.Remove(socket); }
            AppendLog("Client Disconnected: " + socket.RemoteEndPoint);
        }
        private void RunClient(Socket socket)
        {
            try
            {
                AppendLog("Connected to server");
                for (working = true; working;)
                {
                    if (socket.Poll(100, SelectMode.SelectRead))
                    {
                        int size = socket.Available;
                        if (size == 0) break;
                        byte[] buffer = new byte[size];
                        socket.Receive(buffer);
                        AppendLog(UTF8Encoding.UTF8.GetString(buffer));
                    }
                }
            }
            catch (Exception) { }
            AppendLog("Disconnected from server");
        }
        private void RunServer(TcpListener server)
        {
            try
            {
                server.Start();
                AppendLog("Server started");
                for (working = true; working;)
                {
                    if (server.Pending())
                    {
                        Socket socket = server.AcceptSocket();
                        new Thread(() => ClientCall(socket)).Start();
                    }
                }
            }
            catch (Exception) { }
            AppendLog("Server stopped");
            server.Stop();
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (CbServer.Checked)
            {
                TcpListener server = new TcpListener(IPAddress.Any, getPort());
                new Thread(() => RunServer(server)).Start();
            }
            else
            {
                TcpClient client = new TcpClient(EdHost.Text, getPort());
                socket = client.Client;
                new Thread(() => RunClient(socket)).Start();
            }
        }
        private void BtnSend_Click(object sender, EventArgs e)
        {
            string message = EdMessage.Text;



            if (CbServer.Checked)
            {
                byte[] buffer = UTF8Encoding.UTF8.GetBytes("Server: " + message);
                lock (clients) { foreach (Socket tmp in clients) tmp.Send(buffer); }
            }
            else
            {
                socket.Send(UTF8Encoding.UTF8.GetBytes(message));
            }
        }
        private void TcpChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing = true;
            working = false;
        }
    }
}