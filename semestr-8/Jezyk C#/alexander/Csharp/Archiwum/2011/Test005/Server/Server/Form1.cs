using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    public partial class AServer : Form
    {
        private TcpListener srv;
        private Thread th;
        private bool Stopped;
        delegate void DelegateAppendText(string s);
        public AServer()
        {
            InitializeComponent();
            srv = new TcpListener(IPAddress.Any, 8001);
            th = new Thread(listen);
            Stopped = false;
            th.Start();
        }

        void AppendText(string s)
        {
            Log.AppendText(s+"\n");
        }

        void ThreadAppendText(string s)
        {
            Invoke
            (
                new DelegateAppendText(AppendText),
                new object[] { s }
            );
        }

        private void listen()
        {
            try
            {
                srv.Start();
                ThreadAppendText("Serwer wystartowa³");
                while (true)
                {
                    try
                    {
                        while ((!Stopped) && (!srv.Pending())) { }
                        if (Stopped)
                        {
                            srv.Stop();
                            break;
                        }
                        new Thread(work).Start(srv.AcceptSocket());
                    }
                    catch(Exception)
                    {
                     ThreadAppendText("B³¹d przy po³¹czeniu");
                    }
                }
            }
            catch (Exception)
            {
                ThreadAppendText("B³¹d startu");
            }
        }

        private void work(object os)
        {
            Socket s=null;
            ASCIIEncoding en;
            try
            {
                s=os as Socket;
                ThreadAppendText("Po³¹czy³ siê klient "+s.RemoteEndPoint.ToString());
                en=new ASCIIEncoding();
                byte[] buf=new byte[1024];
                string Name=en.GetString(buf, 0, s.Receive(buf));
                
                s.Send(en.GetBytes("Po³¹czy³eœ siê z serwerem"));
                while(s.Connected)
                {
                    try
                    {
                        ThreadAppendText
                        (
                            s.RemoteEndPoint.ToString()+": "+
                            en.GetString(buf,0,s.Receive(buf))
                        );
                    }
                    catch(Exception)
                    {
                    }
                }
                ThreadAppendText("Roz³¹czy³ siê klient " + s.RemoteEndPoint.ToString());
            }
            catch(Exception)
            {
                ThreadAppendText("B³¹d klienta");
                s.Disconnect(true);
            }
        }

        private void AServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stopped = true;
            th.Join();
        }
    }
}