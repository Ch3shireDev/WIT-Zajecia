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
        private List<Socket> clients = new List<Socket>();
        private Socket socket;
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
            else if(!closing) Invoke(new AppendLogProc(AppendLog), new object[] { text });
        }
        private void ClientTalk(Socket socket)
        {
            string who = socket.RemoteEndPoint.ToString();
            try
            {
                // odczytyjemy imie z sokiety
                // dodajemy do mapy who -> imie
                // who poprzez mape konwertujemy do imienia
                AppendLog("Client connected: " + who);
                lock(clients) { clients.Add(socket); }
                while (working)
                {
                    if (socket.Poll(100,SelectMode.SelectRead))
                    {
                        int size = socket.Available;
                        if (size == 0) break;
                        byte[] buff = new byte[size];
                        socket.Receive(buff);
                        string msg = who + ": " + UTF8Encoding.UTF8.GetString(buff);
                        AppendLog(msg);
                        buff = UTF8Encoding.UTF8.GetBytes(msg);
                        lock (clients) { foreach (Socket s in clients) s.Send(buff); }
                    }
                }
            }
            catch (Exception) {}
            lock (clients) { clients.Remove(socket); }
            AppendLog("Client disconnected: " + who);
        }
        private void RunClient(Socket socket)
        {
            try
            {
                // odczytać imię
                // wyslac do servera
                AppendLog("Connected to server");
                for (working = true; working;)
                {
                    if (socket.Poll(100, SelectMode.SelectRead))
                    {
                        int size = socket.Available;
                        if (size == 0) break;
                        byte[] buff = new byte[size];
                        socket.Receive(buff);
                        AppendLog(UTF8Encoding.UTF8.GetString(buff));
                    }
                }
            }
            catch (Exception) {}
            AppendLog("Disconnected to server");
        }
        private void RunServer(TcpListener server)
        {
            try
            {
                AppendLog("Server started");
                server.Start();
                for(working = true; working;)
                {
                    if(server.Pending())
                    {
                        Socket socket = server.AcceptSocket();
                        new Thread(() => ClientTalk(socket)).Start();
                    }
                }
            }
            catch (Exception) {}
            server.Stop();
            AppendLog("Server stopped");
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
                socket = client.Client;
                new Thread(() => RunClient(socket)).Start();
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            socket.Send(UTF8Encoding.UTF8.GetBytes(EdMessage.Text));
        }

        private void TcpChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing = true;
            working = false;
        }
    }
}
