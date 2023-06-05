using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Globalization;

namespace SyncServer
{
    public partial class SyncServer : Form
    {
        public TcpListener Srv;
        public Thread Thr;
        public Object Snc;
        public bool Run;
        private double Sum;
        delegate void SetString(string Str);
        delegate void Event();

        public SyncServer()
        {
            InitializeComponent();
            Snc = new Object();
            Srv = null;
            Thr = null;
            Run = false;
            //NumberFormatInfo.CurrentInfo.NumberDecimalSeparator = ".";
        }

        public void ShowValue()
        {
            Suma.Text = String.Format("{0:0.00}", Sum);
        }

        public void ThrShowValue()
        {
            Invoke(new Event(ShowValue));
        }

        public void LogText(string Text)
        {
            Log.AppendText(Text + "\n");
        }

        public void ThrLogText(string Text)
        {
            Invoke(new SetString(LogText), new Object[] { Text });
        }

        public void OnStart()
        {
            Run = true;
            LogText("Start nas³uchu");
            Srv.Start();
            BtnRun.Text = "&Stop";
            AcceptButton = null;
            CancelButton = BtnRun;
            Sum = 0;
            ShowValue();
        }

        public void ThrOnStart()
        {
            Invoke(new Event(OnStart));
        }

        public void OnStop()
        {
            LogText("Koniec nas³uchu"); 
            BtnRun.Text = "&Start";
            CancelButton = null;
            AcceptButton = BtnRun;
        }

        public void ThrOnStop()
        {
            Invoke(new Event(OnStop));
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            if (Thr != null)
            {
                Run = false;
                Thr.Join();
                OnStop();
                Thr = null;
                Srv = null;
            }
            else
            {
                Srv = new TcpListener(IPAddress.Any, 8002);
                Thr = new Thread(new ThreadStart(listen));
                Thr.Priority = ThreadPriority.BelowNormal;
                Thr.Start();
            }
        }

        public void listen()
        {
            try
            {
                ThrOnStart();
                while (Run)
                {
                    try
                    {
                        if (Srv.Pending())
                        {
                            Thread Th = new Thread(work);
                            Th.Priority = ThreadPriority.BelowNormal;
                            Th.Start(Srv.AcceptSocket());
                        }
                        else
                        {
                            Thread.Sleep(1);
                        }
                    }
                    catch (Exception)
                    {
                        if (Run) ThrLogText("B³¹d nas³uchu");
                        break;
                    }
                }
                Srv.Stop();
                if (Run) ThrOnStop();
            }
            catch (Exception e)
            {
                if (Run) ThrLogText("B³¹d: " + e.Message);
            }
        }

        public void work(Object s)
        {
            Socket sck = s as Socket;
            string who = sck.RemoteEndPoint.ToString();
            ASCIIEncoding en = new ASCIIEncoding();
            //en.CodePage = 1250;
            try
            {
                ThrLogText("Po³¹czenie: " + who);
                //sck.Send(en.GetBytes("Polaczyles sie z serwerem"));
                byte[] buf = new byte[1024];
                while (sck.Connected && Run)
                {
                    if (sck.Poll(1, SelectMode.SelectRead))
                    {
                        if (sck.Available > 0)
                        {
                            string Cmd = en.GetString(buf, 0, sck.Receive(buf));
                            foreach (string cmd in Cmd.Split('\n'))
                            {
                                double Add;
                                if (Double.TryParse(cmd, out Add))
                                {
                                    /*
                                    Monitor.Enter(Snc);
                                    try
                                    {
                                        Sum += Add;
                                    }
                                    finally
                                    {
                                        Monitor.Exit(Snc);
                                    }
                                    */
                                    lock (Snc)
                                    {
                                        Sum += Add;
                                    }
                                    ThrShowValue();
                                }
                                else if(cmd.Length>0)
                                {
                                    ThrLogText(who + ": text -> " + cmd);
                                }
                            }
                        }
                        else break;
                    }
                    else Thread.Sleep(1);
                }
                ThrLogText("Roz³¹czenie: " + who);
            }
            catch (Exception)
            {
                ThrLogText("B³¹d pol¹czenia z: " + who);
            }
            //sck.Disconnect(false);
            sck.Close();
        }

        private void SyncServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Run = false;
            if (Thr!=null) Thr.Join();
        }

    }
}