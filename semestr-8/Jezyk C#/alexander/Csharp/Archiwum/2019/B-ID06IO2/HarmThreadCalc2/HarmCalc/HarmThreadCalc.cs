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

namespace HarmCalc
{
    public partial class HarmThreadCalc : Form
    {
        private delegate void AppendTextProc(string Line);
        private static uint ThreadCount = 4;
        private ulong count= 10000000000UL;

        public HarmThreadCalc()
        {
            InitializeComponent();
            EdCount.Text = count.ToString();
        }

        private void AppendText(string Line)
        {
            EdResults.AppendText(Line + Environment.NewLine);
        }
        private void InvokeAppendText(string Line)
        {
            Invoke(new AppendTextProc(AppendText), new object[] { Line });
        }
        private void EdCount_TextChanged(object sender, EventArgs e)
        {
            BtnCalc.Enabled=(ulong.TryParse(EdCount.Text, out count));
        }

        private void run(ulong cnt)
        {
            double sum = 0;
            HarmThread[] th = new HarmThread[ThreadCount];
            for (uint i = 0; i < ThreadCount; ++i)
            {
                th[i] = new HarmThread(i + 1, cnt, ThreadCount);
            }
            for (uint i = 0; i < ThreadCount; ++i) sum += th[i].partsum();
            InvokeAppendText(String.Format("{0} -> {1:F13}", cnt, sum));
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            new Thread(() => { run(count); }).Start();
            EdCount.SelectAll();
            EdCount.Focus();
        }
    }

    class HarmThread
    {
        private double sum;
        private ulong count;
        private uint start,step;
        private Thread th;
        public HarmThread(uint start, ulong count,uint step)
        {
            this.start = start;
            this.count = count;
            this.step = step;
            th = new Thread(run);
            th.Start();
        }
        private void run()
        {
            sum = 0;
            for (ulong i = start; i <= count; i += step) sum += 1.0 / i;
        }
        public double partsum()
        {
            th.Join();
            return sum;
        }
    }
}
