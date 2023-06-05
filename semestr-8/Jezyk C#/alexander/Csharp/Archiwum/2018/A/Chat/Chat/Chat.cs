using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    delegate void CallWithString(string text);
    public partial class Chat : Form
    {
        private TcpClient cln = null;
        private TcpListener srv = null;
        private Thread th = null;
        private List<Socket> clients = new List<Socket>();
        private UTF8Encoding enc = new UTF8Encoding();
        private bool Running = false;
        public Chat()
        {
            InitializeComponent();
        }
        void LogAppend(string text)
        {
            Log.AppendText(text + Environment.NewLine);
        }
        void InvokeLogAppend(string text)
        {
            Invoke(new CallWithString(LogAppend), new Object[] { text });
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (BtnServer.Enabled)
            {
                BtnServer.Enabled = false;
                EdHost.Enabled = false;
                EdPort.Enabled = false;
                EdSendText.Enabled = true;
                BtnSend.Enabled = true;
                BtnConnect.Text = "Rozłącz";
                if (BtnServer.Checked) th = new Thread(SrvLoop);
                else th = new Thread(TcpLoop);
                th.Start();
            }
            else
            {
                BtnServer.Enabled = true;
                EdHost.Enabled = true;
                EdPort.Enabled = true;
                EdSendText.Enabled = false;
                BtnSend.Enabled = false;
                BtnConnect.Text = "Połącz";
                Running = false;
                if (BtnServer.Checked) srv = null;
                else cln = null;
            }
        }
        private int portValue()
        {
            int port;
            if (!int.TryParse(EdPort.Text, out port))
            {
                port = 8888;
                //EdPort.Text = port.ToString();
            }
            return port;
        }
        void SendTo(Socket sock, string text)
        {
            sock.Send(enc.GetBytes(text));
        }
        void SendToAll(string text)
        {
            byte[] buff = enc.GetBytes(text);
            lock (clients)
            {
                foreach (Socket soc in clients) soc.Send(buff);
            }
        }
        private string ReceiveFrom(Socket conn, int len)
        {
            byte[] buff = new byte[len];
            conn.Receive(buff);
            return enc.GetString(buff);
        }
        void SrvLoop()
        {
            int port = portValue();
            srv = new TcpListener(IPAddress.Any, port);
            srv.Start();
            Running = true;
            while (Running)
            {
                if(srv.Pending())
                {
                    Socket conn = srv.AcceptSocket();
                    Thread clnth = new Thread(ClnLoop);
                    clnth.Start(conn);
                }
            }
            srv.Stop();
        }
        void TcpLoop(Object obj)
        {
            int port = portValue();
            cln = new TcpClient();
            cln.Connect(EdHost.Text, port);
            Socket conn = cln.Client;
            Running = true;
            while (Running)
            {
                if (conn.Poll(10, SelectMode.SelectRead))
                {
                    int len = conn.Available;
                    if (len <= 0) break;
                    string text = ReceiveFrom(conn, len);
                    InvokeLogAppend(conn.RemoteEndPoint + ": " + text);
                }
            }
            if(conn.Connected) conn.Disconnect(false);
        }
        void ClnLoop(Object obj)
        {
            Socket conn = (Socket)obj;
            lock (clients)
            {
                clients.Add(conn);
            }
            while (Running)
            {
                try
                {
                    if (conn.Poll(10, SelectMode.SelectRead))
                    {
                        int len = conn.Available;
                        if (len <= 0) break;
                        string text = conn.RemoteEndPoint + ": " + ReceiveFrom(conn, len);
                        InvokeLogAppend(text);
                        SendToAll(text);
                    }
                }
                catch(Exception)
                {
                    break;
                }
            }
            lock (clients)
            {
                clients.Remove(conn);
            }
            if (conn.Connected) conn.Disconnect(false);
        }
        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (cln != null) SendTo(cln.Client,EdSendText.Text);
            else if (srv != null)
            {
                string text = EdSendText.Text;
                SendToAll(text);
                LogAppend(srv.LocalEndpoint + ": " + text);
            }
            EdSendText.SelectAll();
            EdSendText.Focus();
        }
        private void Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Running = false;
        }
    }
}
