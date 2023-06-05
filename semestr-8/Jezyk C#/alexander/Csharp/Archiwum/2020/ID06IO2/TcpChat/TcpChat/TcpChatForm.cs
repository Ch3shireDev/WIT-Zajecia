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
    delegate void AppendTextProc(string text);
        
    public partial class TcpChatForm : Form
    {
        private static int defaultPort = 6688;
        private bool working;
        private TcpListener srv;
        private TcpClient cln;
        private List<Socket> clients = new List<Socket>();
        public TcpChatForm()
        {
            InitializeComponent();
            EdPort.Text = defaultPort.ToString();
        }
        private int Port 
        {  
            get
            {
                int port;
                if (int.TryParse(EdPort.Text, out port)) return port;
                EdPort.Text = defaultPort.ToString();
                return defaultPort;
            }
        }
        private void AppendText(string text)
        {
            if (InvokeRequired)
            {
                if(working) Invoke(new AppendTextProc(AppendText), new object[] { text });
            }
            else EdLog.AppendText(text + Environment.NewLine);
        }

        private void TalkWithClient(Socket sock)
        {
            try
            {
                working = true;
                AppendText("Connected: " + sock.RemoteEndPoint.ToString());
                lock (clients) { clients.Add(sock); }
                while (working)
                {
                    if (sock.Poll(10,SelectMode.SelectRead))
                    {
                        int size = sock.Available;
                        if (size <= 0) break;
                        byte[] buff = new byte[size];
                        sock.Receive(buff);
                        string msg = sock.RemoteEndPoint.ToString() + ": " + UTF8Encoding.UTF8.GetString(buff);
                        buff = UTF8Encoding.UTF8.GetBytes(msg);
                        lock (clients)
                        {
                            foreach (Socket s in clients) s.Send(buff);
                        }
                        AppendText(msg);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            lock (clients) { clients.Remove(sock); }
            sock.Disconnect(false);
            //AppendText("Disconnect: " + sock.RemoteEndPoint.ToString());
        }
        private void ListenThread()
        {
            srv.Start();
            try
            {
                working = true;
                AppendText("Server started");
                while (working)
                {
                    if (srv.Pending())
                    {
                        Socket socket = srv.AcceptSocket();
                        new Thread(() => TalkWithClient(socket)).Start();
                    }
                }
            }
            catch(Exception ex)
            {

            }
            AppendText("Server stoped");
            srv.Stop();
        }
        private void ClientThread()
        {
            try
            {
                Socket sock = cln.Client;
                working = true;
                while (working)
                {
                    if (sock.Poll(10, SelectMode.SelectRead))
                    {
                        int size = sock.Available;
                        if (size <= 0) break;
                        byte[] buff = new byte[size];
                        sock.Receive(buff);
                        string msg = UTF8Encoding.UTF8.GetString(buff);
                        AppendText(msg);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if(CbServer.Checked)
            {
                srv = new TcpListener(IPAddress.Any,Port);
                new Thread(ListenThread).Start();
            }
            else
            {
                cln = new TcpClient(EdHost.Text, Port);
                new Thread(ClientThread).Start();
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            String msg = EdMessage.Text;
            byte[] buff=UTF8Encoding.UTF8.GetBytes(msg);
            cln.Client.Send(buff);
            EdMessage.SelectAll();
            EdMessage.Focus();
        }

        private void TcpChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            working = false;
        }
    }
}
