using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadHarmonicSequence
{
    delegate void AppendLogDelegate(string method, ulong count, double sum, DateTime dt);
    public partial class ThreadHarmonicSequenceForm : Form
    {
        private ulong count = 30000000UL;
        public ThreadHarmonicSequenceForm()
        {
            InitializeComponent();
            TbCount.Text = count.ToString();
        }

        private static double Sum(ulong count)
        {
            double sum = 0;
            for (ulong i = 1; i <= count; ++i) sum += 1.0D / i;
            return sum;
        }

        private void AppendLog(string method, ulong count, double sum, DateTime dt)
        {
            if (InvokeRequired) Invoke(new AppendLogDelegate(AppendLog), new object[] { method, count, sum, dt });
            //TbLog.AppendText(string.Format("{0}: Sum({1}) => {2:F18} ({3})", method, count, sum, dt.ToString("HH:mm:ss.ffffff")) +Environment.NewLine);
            else TbLog.AppendText($"{method}: Sum({count}) => {sum.ToString("F18")} ({dt.ToString("HH:mm:ss.ffffff")}){Environment.NewLine}");
        }

        private void TbCount_TextChanged(object sender, EventArgs e)
        {
            bool ok = ulong.TryParse(TbCount.Text, out count);
            BtnSimple.Enabled = BtnThread.Enabled = BtnParallel.Enabled = ok;
            TbCount.BackColor = ok ? SystemColors.Window : Color.Yellow;
        }

        private void BtnSimple_Click(object sender, EventArgs e)
        {
            ulong count = this.count;
            AppendLog("S", count, Sum(count), DateTime.Now);
        }

        private void BtnThread_Click(object sender, EventArgs e)
        {
            ulong count = this.count;
            new Thread(() => AppendLog("T", count, Sum(count), DateTime.Now)).Start();
        }
    }
}
