using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading; //
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; //
using System.Net.Sockets; //

namespace TcpChat
{
    public partial class TcpChatForm : Form
    {
        private static int defaultPort = 6688;
        private List<Socket> clients = new List<Socket>();
        private Socket clientSocket;
        private bool working, closing = false;
        public TcpChatForm()
        {
            InitializeComponent();
            EdPort.Text = defaultPort.ToString();
        }
        private int getPort()
        {
            int port = defaultPort;
            int.TryParse(EdPort.Text, out port);
            EdPort.Text = port.ToString();
            return port;
        }
        delegate void AppendLogProc(string text);
        private void AppendLog(string text)
        {
            if (!InvokeRequired) EdLog.AppendText(text + Environment.NewLine);
            else if (!closing) Invoke(new AppendLogProc(AppendLog),new object[] { text });
        }
        private void ClienCall(Socket socket)
        {
            try
            {
                AppendLog("Connected: " + socket.RemoteEndPoint.ToString());
                lock (clients) {  clients.Add(socket); }
                for (working = true; working;)
                {
                    if (socket.Poll(100,SelectMode.SelectRead))
                    {
                        int size = socket.Available;
                        byte[] buffer = new byte[size];
                        socket.Receive(buffer);
                        string msg = socket.RemoteEndPoint.ToString() + ": " + UTF8Encoding.UTF8.GetString(buffer);
                        AppendLog(msg);
                        buffer = UTF8Encoding.UTF8.GetBytes(msg);
                        lock (clients) { foreach (Socket sock in clients) sock.Send(buffer); }
                    }
                }
            }
            catch (Exception) { }
            lock (clients) { clients.Remove(socket); }
            AppendLog("Disconnected: " + socket.RemoteEndPoint.ToString());
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
                    if(server.Pending())
                    {
                        Socket socket = server.AcceptSocket();
                        new Thread(() => ClienCall(socket)).Start();
                    }
                }
            }
            catch (Exception) {}
            AppendLog("Server stoped");
            server.Stop();
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if(CbServer.Checked)
            {
                TcpListener server = new TcpListener(IPAddress.Any, getPort());
                new Thread(() => RunServer(server)).Start();
            }
            else
            {
                TcpClient client = new TcpClient(EdHost.Text, getPort());
                clientSocket = client.Client;
                new Thread(() => RunClient(clientSocket)).Start();
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (CbServer.Checked)
            {

            }
            else
            {
                clientSocket.Send(UTF8Encoding.UTF8.GetBytes(EdMessage.Text));
                EdMessage.SelectAll();
                EdMessage.Focus();
            }
        }

        private void TcpChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            working = false;
            closing = true;
        }
    }
}
