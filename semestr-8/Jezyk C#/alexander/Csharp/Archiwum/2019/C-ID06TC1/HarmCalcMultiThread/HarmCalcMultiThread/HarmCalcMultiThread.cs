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

namespace HarmCalcSimple
{
    delegate void AppendStringProc(string str);
    public partial class HarmCalcMultiThread : Form
    {
        private ulong count = 1000000000;
        private const uint MaxThreadCount = 4;
        public HarmCalcMultiThread()
        {
            InitializeComponent();
            EValue.Text = count.ToString();
        }

        private double calculate(uint start, ulong count)
        {
            double sum = 0;
            for (ulong i = start; i <= count; i += MaxThreadCount) sum += 1D / i;
            return sum;
        }

        private void append(string str)
        {
            EResult.AppendText(str + Environment.NewLine);
        }

        private void InvokeAppend(string str)
        {
            Invoke(new AppendStringProc(append), new object[] { str });
        }

        private void EValue_TextChanged(object sender, EventArgs e)
        {
            BtnCalc.Enabled = UInt64.TryParse(EValue.Text.Trim(), out count);
        }

        private void RunThreadPartCalc(ref uint start,ulong count,double[] part)
        {
            uint idx=0;
            lock (Thread.CurrentThread) { idx = start++; }
            part[idx] = calculate(idx + 1, count);
        }

        private void RunThreadCalc(ulong count)
        {
            Thread[] th = new Thread[MaxThreadCount];
            double[] parts = new double[MaxThreadCount];
            uint start = 0;
            for (uint i = 0; i < MaxThreadCount; ++i)
            {
                th[i] = new Thread(() => RunThreadPartCalc(ref start, count, parts));
            }
            for (uint i = 0; i < MaxThreadCount; ++i) th[i].Start();
            for (uint i = 0; i < MaxThreadCount; ++i) th[i].Join();
            double sum = 0;
            for (uint i = 0; i < MaxThreadCount; ++i) sum += parts[i];

            InvokeAppend(count.ToString() + " -> " + sum.ToString());
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            new Thread(() => RunThreadCalc(count)).Start();
            EValue.SelectAll();
            EValue.Focus();
        }
    }
}
