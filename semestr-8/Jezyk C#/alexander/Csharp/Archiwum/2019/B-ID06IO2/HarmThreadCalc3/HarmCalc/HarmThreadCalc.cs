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
        private ulong count = 10000000000UL;
        private Object ini = new Object();
        private Object fin = new Object();

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
            BtnCalc.Enabled = (ulong.TryParse(EdCount.Text, out count));
        }

        private void run(ref uint start, ulong cnt, uint step, ref uint done, ref double sum)
        {
            uint s = 0;
            lock (ini)
            {
                s = ++start;
            }
            double part = 0;
            for (ulong i = s; i <= cnt; i += step) part += 1.0 / i;
            bool ok = false;
            lock (fin)
            {
                sum += part;
                ok = (++done == ThreadCount);
            }
            if (ok) InvokeAppendText(String.Format("{0} -> {1:F13}", cnt, sum));
        }

        private void run(ulong cnt)
        {
            double sum = 0;
            uint done = 0, start = 0;
            for (uint i = 1; i <= ThreadCount; ++i)
            {
                new Thread(() => run(ref start, count, ThreadCount, ref done, ref sum)).Start();
            }
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            new Thread(() => run(count)).Start();
            EdCount.SelectAll();
            EdCount.Focus();
        }
    }
}
