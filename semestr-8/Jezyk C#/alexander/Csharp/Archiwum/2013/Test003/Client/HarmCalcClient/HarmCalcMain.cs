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
        delegate void DelegateSetBarValue(ProgressBar bar, int value);
        delegate void DelegateDisconnect();
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
                if (bar.Maximum >= value) bar.Value = value;
                else Box.Controls.Remove(bar);
            }
        }

        private void work(Object arg)
        {
            Object[] Arr = (Object[])arg; // Parametrem jest tablica obiektów
            ProgressBar bar = (ProgressBar)(Arr[0]);
            ulong count = (UInt64)(Arr[1]);
            String Host = (String)(Arr[2]);
            int Port = (Int32)(Arr[3]);
            TcpClient cln = new TcpClient(Host, Port);
            ASCIIEncoding en = new ASCIIEncoding();
            cln.Client.Send(en.GetBytes(count.ToString()));
            byte[] buf = new byte[1024];
            while ((!Stopped) && (cln.Client.Connected))
            {
                try
                {
                    if (cln.Client.Poll(5, SelectMode.SelectRead))
                    {
                        if (cln.Available > 0)
                        {
                            foreach (String str in en.GetString(buf, 0, cln.Client.Receive(buf)).Split('\n'))
                            {
                                if (str.Substring(0, 1) == "p") SetBarValue(bar, Int32.Parse(str.Substring(1)));
                                else
                                {
                                    AppendText(str);
                                    break;
                                }
                            }

                        }
                        else break;
                    }

                }
                catch (Exception)
                {
                }
            }
            try
            {
                cln.Client.Disconnect(true);
            }
            catch (Exception)
            {
            }
            SetBarValue(bar, 101);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            ulong count;
            if (UInt64.TryParse(ECount.Text, out count))
            {
                ProgressBar bar = new ProgressBar();
                bar.Size = new Size(100, 23);
                bar.Dock = DockStyle.Top;
                Box.Controls.Add(bar);
                int Port = 8083;
                Int32.TryParse(EPort.Text, out Port);
                EPort.Text = Port.ToString();
                new Thread(work).Start(new Object[] { bar, count, EHost.Text, Port });
            }
            else AppendText(String.Format("{0,-16}\t- nie jest liczbą", ECount.Text));
            ECount.SelectAll();
            ECount.Focus();
        }

        private void HarmCalcMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stopped = true;
            while (Box.Controls.Count > 0) Application.DoEvents();
        }
    }
}