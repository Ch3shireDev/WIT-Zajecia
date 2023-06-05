using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;


namespace Server
{
    public partial class Server : Form
    {
        private List<Socket> lst = new List<Socket>();
        private TcpListener srv;
        private Thread thr;
        private bool Run;
        public delegate void CallAppendText(string Str);
        public delegate void CallStopAdjust();

        public Server()
        {
            InitializeComponent();
        }

        private void AppendText(string Str)
        {
            if(InvokeRequired)
            {
                Invoke(new CallAppendText(AppendText), new Object[] { Str });
            }
            else LogBox.AppendText(Str+Environment.NewLine);
        }

        private void StopAdjust()
        {
            if (InvokeRequired)
            {
                if(Port.Visible) Invoke(new CallStopAdjust(StopAdjust));
            }
            else
            {
                Port.ReadOnly = false;
            }
        }

        private void work()
        {
            srv.Start();
            while(Run)
            {
                if(srv.Pending())
                {
                    new Thread(client).Start(srv.AcceptSocket());
                }
            }
            srv.Stop();
            StopAdjust();
        }

        private void client(Object param)
        {
            Socket sck = param as Socket;
            try
            {
                lock (lst)
                {
                    lst.Add(sck);
                }
                ASCIIEncoding en = new ASCIIEncoding();
                byte[] bufer = new byte[1024];
                AppendText(sck.RemoteEndPoint.ToString());
                while ((Run) && (sck.Connected))
                {
                    if (sck.Poll(5, SelectMode.SelectRead))
                    {
                        if (sck.Available <= 0) break;
                        String Info = sck.RemoteEndPoint.ToString() + " => " + en.GetString(bufer, 0, sck.Receive(bufer));
                        AppendText(Info);
                        lock (lst)
                        {
                            foreach(Socket s in lst)
                            {
                                if(s != sck)
                                {
                                    s.Send(en.GetBytes(Info));
                                }
                            }
                        }
                    }
                }
                sck.Disconnect(true);
            }
            finally
            {
                lock (lst)
                {
                    lst.Remove(sck);
                }
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (Port.ReadOnly)
            {
                Port.ReadOnly = false;
                Run = false;
                BtnConnect.Text = "Połącz";
            }
            else
            { 
                Port.ReadOnly = true;
                srv = new TcpListener(IPAddress.Any, int.Parse(Port.Text));
                Run = true;
                thr = new Thread(work);
                thr.Start();
                BtnConnect.Text = "Zatrzymaj";
            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            Port.Visible = false;
            Run = false;
        }
    }
}
