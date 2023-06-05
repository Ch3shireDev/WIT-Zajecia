using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HarmCalcWorker
{
    public partial class HarmCalcMain : Form
    {
        public bool Stopped;

        public HarmCalcMain()
        {
            InitializeComponent();
            Stopped = false;
        }

        public void AppendText(string s)
        {
            EResult.AppendText(s + Environment.NewLine);
        }

        public void SetBarValue(ProgressBar bar, int value)
        {
            bar.Value = value;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            new Data(this); // klasa niżej
            ECount.SelectAll();
            ECount.Focus();
        }

        public void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            Data data = (Data)e.Argument; // argument z wywołania RunWorkerAsync
            double sum = 0;
            int pr = -1;
            for (ulong i = 1; i < data.count; ++i)
            {
                sum += 1.0 / i;
                if ((i & 0x3FFF) == 0)
                {
                    if (Stopped) break;
                    int npr = (int)(i * 100.0 / data.count + 0.5);
                    if (pr != npr) data.bgw.ReportProgress(pr = npr, data.bar);
                }
            }
            data.sum = sum;
            e.Result = data;
        }

        public void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ((ProgressBar)e.UserState).Value = e.ProgressPercentage;
        }

        public void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Data data = (Data)e.Result;
            Box.Controls.Remove(data.bar);
            AppendText(String.Format("{0,-16}\t- {1,22:0.000000000000000000}", data.count, data.sum));
        }
    }

    public class Data
    {
        public ProgressBar bar;
        public BackgroundWorker bgw;
        public ulong count;
        public double sum;
        public Data(HarmCalcMain frm)
        {
            if (UInt64.TryParse(frm.ECount.Text, out count))
            {
                bar = new ProgressBar();
                bar.Size = new Size(100, 23);
                bar.Dock = DockStyle.Top;
                bar.Tag = this;
                frm.Box.Controls.Add(bar);
                bgw = new BackgroundWorker();
                bgw.DoWork += frm.bgw_DoWork;
                bgw.ProgressChanged += frm.bgw_ProgressChanged;
                bgw.RunWorkerCompleted += frm.bgw_RunWorkerCompleted;
                bgw.WorkerReportsProgress = true;
                bgw.RunWorkerAsync(this);
            }
            else frm.AppendText(String.Format("{0,-16}\t- nie jest liczbą", frm.ECount.Text));
        }
    }
}
