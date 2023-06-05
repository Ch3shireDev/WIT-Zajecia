using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    delegate void SendStringInfo(string msg);
    public partial class ServerMain : Form
    {
        private TcpListener srv = null;
        private Thread th = null;
        private List<Connection> con;
        public ServerMain()
        {
            InitializeComponent();
            con = new List<Connection>();
        }
        private void AppendInfo(string msg)
        {
            txtInfo.AppendText(DateTime.Now.ToString("T")+" - "+msg+Environment.NewLine);
        }
        private void ClientInfo(string msg)
        {
            Invoke(new SendStringInfo(AppendInfo), msg);
            foreach (Connection c in con) c.SendText(msg);
        }
        private void btnListen_Click(object sender, EventArgs e)
        {
            if (srv == null)
            {
                try
                {
                    srv = new TcpListener(IPAddress.Any, int.Parse(txtPort.Text));
                    th = new Thread(listen);
                    srv.Start();
                    th.Start();
                    btnListen.Text = "Stop";
                    AcceptButton = null;
                    CancelButton = btnListen;
                    AppendInfo("Nasłuchiwanie");
                }
                catch (Exception ex)
                {
                    AppendInfo(string.Format("Błąd: {0}", ex.Message));
                    srv = null;
                    th = null;
                }
            }
            else
            {
                th = null;
                btnListen.Text = "Nasłuchuj";
                CancelButton = null;
                AcceptButton = btnListen;
            }
        }
        private void listen()
        {
            while (th != null)
            {
                if (srv.Pending())
                {
                    con.Add(new Connection(srv.AcceptSocket(),new SendStringInfo(ClientInfo)));
                }
                else Thread.Sleep(5);
            }
            if(srv!=null) srv.Stop();
            srv = null;
        }
        private void ServerMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Thread tmp = th;
            th = null;
            if(tmp!=null) tmp.Join();
        }
    }
    class Connection
    {
        private Thread th;
        private Socket sock;
        private static UTF8Encoding en = new UTF8Encoding();
        private event SendStringInfo callback;
        private string who;
        public Connection(Socket sock, SendStringInfo callback)
        {
            this.sock = sock;
            this.callback += callback;
            who = sock.RemoteEndPoint.ToString()+": ";
            th = new Thread(worker);
            th.Start();
        }
        private void worker()
        {
            callback(who + "Połączono");
            while (th != null) 
            {
                if (sock.Poll(10, SelectMode.SelectRead))
                {
                    int size = sock.Available;
                    if (size <= 0) th = null;
                    else
                    {
                        byte[] buff = new byte[size];
                        string str = en.GetString(buff, 0, sock.Receive(buff));
                        callback(who + str);
                    }
                }
                else Thread.Sleep(5);
            }
            try { sock.Disconnect(true); } catch(Exception ex) {}
            callback(who + "Rozłączono");
        }
        public void SendText(string msg)
        {
            try { sock.Send(en.GetBytes(msg)); } catch (Exception ex) { }
        }
        public void Join()
        {
            Thread tmp = th;
            th = null;
            tmp.Join();
        }
    }
}
