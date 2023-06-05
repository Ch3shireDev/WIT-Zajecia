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
        private bool working,closing=false;
        private TcpClient client;
        private List<Socket> clients = new List<Socket>();
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
        delegate void AppendTextProc(string text);
        private void InvokeAction(Action action) { Invoke(action); }
        private void AppendText(string text)
        {
            if (!InvokeRequired) EdLog.AppendText(text + Environment.NewLine);
            else if (!closing) InvokeAction(() => AppendText(text));
            //else if (!closing) Invoke(new Action(() => AppendText(text)));
            //else if (!closing) Invoke((MethodInvoker)(() => AppendText(text)));
            //else if (!closing) Invoke(new AppendTextProc(AppendText), new object[] { text });
        }
        private void ClientCall(Socket socket)
        {
            try
            {
                AppendText("Client Connected: " + socket.RemoteEndPoint.ToString());
                lock (clients) { clients.Add(socket); }
                working = true;
                while (working)
                {
                    if (socket.Poll(10,SelectMode.SelectRead))
                    {
                        int size = socket.Available;
                        byte[] buff = new byte[size];
                        socket.Receive(buff);
                        string msg=socket.RemoteEndPoint.ToString() + ": " + UTF8Encoding.UTF8.GetString(buff);
                        AppendText(msg);
                        buff = UTF8Encoding.UTF8.GetBytes(msg);
                        lock (clients) { foreach (Socket sock in clients) sock.Send(buff); }
                    }
                }
            }
            catch (Exception ex) { }
            lock (clients) { clients.Remove(socket); }
            AppendText("Client Disconnected: " + socket.RemoteEndPoint.ToString());
        }
        private void RunClient()
        {
            Socket socket = client.Client;
            try
            {
                AppendText("Connected: " + socket.RemoteEndPoint.ToString());
                working = true;
                while (working)
                {
                    if (socket.Poll(10, SelectMode.SelectRead))
                    {
                        int size = socket.Available;
                        byte[] buff = new byte[size];
                        socket.Receive(buff);
                        AppendText(UTF8Encoding.UTF8.GetString(buff));
                    }
                }
            }
            catch (Exception ex) { }
            AppendText("Disconnected: " + socket.RemoteEndPoint.ToString());
        }
        private void RunServer(TcpListener server)
        {
            try
            {
                server.Start();
                AppendText("Server Started");
                working = true;
                while (working)
                {
                    if (server.Pending())
                    {
                        Socket socket = server.AcceptSocket();
                        new Thread(() => ClientCall(socket)).Start();
                    }
                    else Thread.Sleep(10);
                }
            }
            catch (Exception ex) { }
            AppendText("Server Stopped");
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
                client = new TcpClient(EdHost.Text, getPort());
                new Thread(() => RunClient()).Start();
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            client.Client.Send(UTF8Encoding.UTF8.GetBytes(EdMessage.Text));
            EdMessage.SelectAll();
            EdMessage.Focus();
        }

        private void TcpChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing = true;
            working = false;
        }
    }
}
