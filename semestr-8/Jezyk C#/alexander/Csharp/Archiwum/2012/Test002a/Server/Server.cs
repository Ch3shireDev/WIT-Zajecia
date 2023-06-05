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
        private TcpListener Srv;
        private Thread Th;
        private bool Work;
        private delegate void SetText(string str);

        public AServer()
        {
            InitializeComponent();
            Work = true;
            Srv = new TcpListener(IPAddress.Any, 8001);
            //th = new Thread(new ThreadStart(listen));
            Th = new Thread(listen);
            Th.Priority = ThreadPriority.BelowNormal;
            Th.Start();
        }

        public void AppendText(string str)
        {
            Log.AppendText(str + "\n");
        }

        public void ThreadAppendText(string str)
        {
            Invoke
            (
                new SetText(AppendText),
//                AppendText,
                new Object[] { str }
            );
        }

        public void listen()
        {
            try
            {
                while (Work)
                {
                    ThreadAppendText("Start nas³uchu");
                    Srv.Start();
                    while (Work)
                    {
                        try
                        {
                            if (Srv.Pending())
                            {
                                Thread Th = new Thread(work);
                                Th.Priority = ThreadPriority.BelowNormal;
                                Th.Start(Srv.AcceptSocket());
                            }
                        }
                        catch (Exception)
                        {
                            if(Work) ThreadAppendText("B³¹d nas³uchu");
                            break;
                        }
                    }
                    Srv.Stop();
                    if (Work) ThreadAppendText("Koniec nas³uchu");
                }
            }
            catch (Exception)
            {
                if (Work) ThreadAppendText("B³¹d po³¹czenia");
            }
        }

       public void work(Object s)
       {
            Socket sck = s as Socket;
            string who = sck.RemoteEndPoint.ToString();
            ASCIIEncoding en=new ASCIIEncoding();
            //en.CodePage = 1250;
            try
            {
                ThreadAppendText("Po³¹czenie: " + who);
                sck.Send(en.GetBytes("Po³¹czy³eœ siê z serwerem"));
                byte[] buf=new byte[1024];
                while (sck.Connected)
                {
                    if (sck.Available>0)
                    {
                        string cmd = en.GetString(buf, 0, sck.Receive(buf));
                        ThreadAppendText(who + ": " + cmd);
                    }
                }
                ThreadAppendText("Roz³¹czenie: " + who);
            }
            catch (Exception)
            {
                ThreadAppendText("B³¹d pol¹czenia z: " + who);
            }
            //sck.Disconnect(false);
            sck.Close();
        }

        private void AServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Work = false;
            Th.Join();
        }
    }
}