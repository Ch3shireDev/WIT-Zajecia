using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ThreadsHarmonicSequence
{
    delegate void AppendLogProc(string method, ulong count, double sum, DateTime dt);
    public partial class HarmonicSequenceMain : Form
    {
        private ulong count = 500000000UL;
        public HarmonicSequenceMain()
        {
            InitializeComponent();
            TbCount.Text = count.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool ok = ulong.TryParse(TbCount.Text, out count);
            BtnSimple.Enabled = ok;
            BtnThread.Enabled = ok;
            BtnParallel.Enabled = ok;
            TbCount.BackColor = ok ? SystemColors.Window : Color.Yellow;
        }

        private double Sum(ulong count)
        {
            double result = 0;
            for (ulong i = 1; i <= count; ++i) result += 1.0D / i;
            return result;
        }

        private void AppendLog(string method,ulong count,double sum, DateTime dt)
        {
            if (InvokeRequired)
            {
                Invoke(new AppendLogProc(AppendLog), new object[] { method, count, sum, dt });
            }
            else TbLog.AppendText(string.Format("{0}: {1} => {2:F18} ({3})", method, count, sum, dt.ToString()) + Environment.NewLine);
        }

        private void BtnSimple_Click(object sender, EventArgs e)
        {
            AppendLog("S", count, Sum(count), DateTime.Now);
        }

        private void BtnThread_Click(object sender, EventArgs e)
        {
            ulong count = this.count;
            new Thread(() => AppendLog("T", count, Sum(count), DateTime.Now)).Start();
        }
    }
}
