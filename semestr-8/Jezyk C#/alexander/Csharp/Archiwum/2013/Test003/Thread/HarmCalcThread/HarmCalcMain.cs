using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace HarmCalcThread
{
    public partial class HarmCalcMain : Form
    {
        delegate void DelegateAppendText(string s);
        delegate void DelegateSetBarValue(ProgressBar bar,int value);
        public bool Stopped;

        public HarmCalcMain()
        {
            InitializeComponent();
            Stopped = false;
        }

        public void AppendText(string s)
        {
            if (InvokeRequired) // czy trzeba to wywołać przez Invoke?
            {
                Invoke // wywołujemy samą siebie przez Invoke
                (
                    new DelegateAppendText(AppendText),
                    new object[] { s }
                );
            }
            else // nie trzeba - robimy bezpośrednio
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

        private void BtnStart_Click(object sender, EventArgs e)
        {
            new Worker(this);
            ECount.SelectAll();
            ECount.Focus();
        }

        private void HarmCalcMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stopped = true;
            while (Box.Controls.Count > 0) Application.DoEvents(); // wykonanie komunikatów aplikacji
        }
    }

    public class Worker
    {
        HarmCalcMain frm;
        ProgressBar bar;
        Thread thr;
        private ulong count;
        private double sum;
        public Worker(HarmCalcMain Frm)
        {
            frm=Frm;
            if (UInt64.TryParse(frm.ECount.Text, out count))
            {
                bar = new ProgressBar();
                bar.Size = new Size(100, 23);
                bar.Dock = DockStyle.Top;
                bar.Tag=this;
                frm.Box.Controls.Add(bar);
                thr = new Thread(work);
                thr.Start();
            }
            else frm.AppendText(String.Format("{0,-16}\t- nie jest liczbą",frm.ECount.Text));
        }

        private void work()
        {
            sum=0;
            int pr = -1;
            for (ulong i = 1; i < count; ++i)
            {
                sum += 1.0 / i;
                if ((i & 0x3FFF)==0)
                {
                    if (frm.Stopped) break;
                    int npr = (int)(i * 100.0 / count + 0.5);
                    if (pr != npr) frm.SetBarValue(bar,pr = npr);
                }
            }
            frm.SetBarValue(bar, 101);
            frm.AppendText(String.Format("{0,-16}\t- {1,22:0.000000000000000000}", count, sum));
        }
    }
}
