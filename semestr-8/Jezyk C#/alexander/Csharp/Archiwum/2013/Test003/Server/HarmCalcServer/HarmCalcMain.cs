using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace HarmCalcThread
{
    public partial class HarmCalcMain : Form
    {
        delegate void DelegateAppendText(string s);
        delegate void DelegateSetBarValue(ProgressBar bar,int value);
        private TcpListener srv;
        private Thread th;
        public bool Stopped;

        public HarmCalcMain()
        {
            InitializeComponent();
            Stopped = false;
        }

        public void AppendText(string s)
        {
            if (InvokeRequired)
            {
                Invoke
                (
                    new DelegateAppendText(AppendText),
                    new object[] { s }
                );
            }
            else
            {
                EResult.AppendText(s + Environment.NewLine);
            }
        }

        public void SetBarValue(ProgressBar bar, int value)
        {
            if (InvokeRequired)
            {
                Invoke
                (
                    new DelegateSetBarValue(SetBarValue),
                    new object[] { bar, value }
                );
            }
            else
            {
                if (value > bar.Maximum) Box.Controls.Remove(bar);
                else if (value < bar.Minimum) Box.Controls.Add(bar);
                else bar.Value = value;
            }
        }

        private void listen()
        {
            try
            {
                srv.Start();
                AppendText("Serwer wystartował");
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
                        new Thread(work).Start(srv.AcceptSocket()); // wywoła metode work z parametrem srv.AcceptSocket()
                    }
                    catch (Exception)
                    {
                        AppendText("Błąd przy połączeniu");
                    }
                }
            }
            catch (Exception)
            {
                AppendText("Błąd startu");
            }
            th = null;
        }

        private void work(object os)
        {
            Socket s = null;
            ASCIIEncoding en;
            try
            {
                s = os as Socket;
                en = new ASCIIEncoding();
                byte[] buf = new byte[1024];
                while ((!Stopped) && (s.Connected))
                {
                    try
                    {
                        if (s.Poll(5, SelectMode.SelectRead)) // Mamy dane lub rozłączenie
                        {
                            if (s.Available > 0) // Mamy dane - tyle ile zwróci s.Available
                            {
                                ulong count=UInt64.Parse(en.GetString(buf, 0, s.Receive(buf)));

                                ProgressBar bar = new ProgressBar();
                                bar.Size = new Size(100, 23);
                                bar.Dock = DockStyle.Top;
                                SetBarValue(bar, -1);
                                double sum = 0;
                                int pr = -1;
                                for (ulong i = 1; i < count; ++i)
                                {
                                    sum += 1.0 / i;
                                    if ((i & 0x3FFF) == 0)
                                    {
                                        if (Stopped) break;
                                        int npr = (int)(i * 100.0 / count + 0.5);
                                        if (pr != npr)
                                        {
                                            SetBarValue(bar, pr = npr);
                                            s.Send(en.GetBytes("p"+pr.ToString()));
                                        }
                                    }
                                }
                                SetBarValue(bar, 101);
                                String Answer = String.Format("{0,-16}\t- {1,22:0.000000000000000000}", count, sum);
                                AppendText(s.RemoteEndPoint.ToString() + ": " + Answer);
                                s.Send(en.GetBytes(Answer));
                                s.Disconnect(true);
                            }
                            break;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            catch (Exception)
            {
                if (s.Connected) s.Disconnect(true);
            }
            th = null;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (AcceptButton == BtnConnect)
            {
                AcceptButton = null;
                CancelButton = BtnConnect;
                BtnConnect.Text = "Rozłącz";
                EPort.ReadOnly = true;
                int Port = 8083;
                Int32.TryParse(EPort.Text, out Port);
                EPort.Text = Port.ToString();
                srv = new TcpListener(IPAddress.Any, Port);
                th = new Thread(listen);
                Stopped = false;
                th.Start();
            }
            else
            {
                CancelButton = null;
                AcceptButton = BtnConnect;
                BtnConnect.Text = "Połącz";
                EPort.ReadOnly = false;
                Stopped = true;
                srv = null;
                th = null;
            }
        }

        private void HarmCalcMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stopped = true;
            while (Box.Controls.Count > 0) Application.DoEvents();
        }
    }
}
