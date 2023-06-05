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

namespace SyncClient
{
    public partial class SyncClient : Form
    {
        private TcpClient Cln;
        private Thread Thr;
        private ASCIIEncoding en;
        private Random Rnd;
        private bool Run;
        private double Add;
        private double Sum;
        delegate void SetString(string Str);
        delegate void Event();

        public SyncClient()
        {
            InitializeComponent();
            en = new ASCIIEncoding();
            Rnd = new Random();
            Thr = null;
            Cln = null;
            Add = 0;
            Sum = 0;
        }

        public void GenValue()
        {
            Add = ((int)(100+899*Rnd.NextDouble()))/100.0;
            Sum += Add;
            Suma.Text = String.Format("{0:0.00}", Sum);
        }

        public void ThrGenValue()
        {
            Invoke(new Event(GenValue));
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
            BtnRun.Text = "&Disconnect";
            AcceptButton = null;
            CancelButton = BtnRun;
            Host.Enabled = false;
            Host.SelectAll();
            Host.Focus();
            LogText("Polaczono");
        }

        public void ThrOnStart()
        {
            Invoke(new Event(OnStart));
        }

        public void OnStop()
        {
            BtnRun.Text = "&Connect";
            CancelButton = null;
            AcceptButton = BtnRun;
            Host.Enabled = true;
            Host.SelectAll();
            Host.Focus();
            LogText("Rozlaczono");
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
            }
            else
            {
                Run = true;
                Thr = new Thread(work);
                Thr.Priority = ThreadPriority.BelowNormal;
                Thr.Start();
            }
        }

        private void SyncClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Run = false;
            if (Thr != null) Thr.Join();
        }

        private void work()
        {
            try
            {
                byte[] buf = new byte[1024];
                Cln = new TcpClient(Host.Text, 8002);
                ThrOnStart();
                Cln.ReceiveTimeout = 5;
                while (Cln.Connected && Run)
                {
                    try
                    {
                        if (Cln.Client.Poll(5, SelectMode.SelectRead))
                        {
                            if (Cln.Available > 0)
                            {
                                string cmd = en.GetString(buf, 0, Cln.Client.Receive(buf));
                                ThrLogText(cmd);
                            }
                            else break;
                        }
                        else
                        {
                            ThrGenValue();
                            Cln.Client.Send(en.GetBytes(String.Format("{0:0.00}", Add)+"\n"));
                            Thread.Sleep(500);
                        }
                    }
                    catch (Exception e)
                    {
                        if (Run) ThrLogText("B³¹d komunikacji: "+e.Message);
                    }
                }
                Cln.Close();
                if (Run) ThrOnStop();
                Cln = null;
            }
            catch (Exception e)
            {
                if (Run) ThrLogText("B³¹d po³¹czenia: " + e.Message);
            }
        }

    }
}