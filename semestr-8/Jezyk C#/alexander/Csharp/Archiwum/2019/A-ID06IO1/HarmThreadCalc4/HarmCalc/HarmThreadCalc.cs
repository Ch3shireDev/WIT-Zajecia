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
    public delegate void ReportResult(ulong count,double value);
    public delegate void ReportResultPart(double value);
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

        private void reported(ulong count,double sum)
        {
            InvokeAppendText(String.Format("{0} -> {1:F13}", count, sum));
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            new HarmSum(count, reported);
            EdCount.SelectAll();
            EdCount.Focus();
        }
    }

    class HarmSum
    {
        public static readonly uint ThreadCount = 4;
        private object lck = new object();
        private double sum=0;
        private uint done=0;
        private ulong count;
        private ReportResult reportDone;
        public HarmSum(ulong count, ReportResult reportDone)
        {
            this.count = count;
            this.reportDone = reportDone;
            new Thread(run).Start();
        }
        private void reported(double part)
        {
            bool ok = false;
            lock(lck)
            {
                sum += part;
                ok = (++done == ThreadCount);
            }
            if (ok) reportDone(count,sum);
        }
        private void run()
        {
            for (uint i = 0; i < ThreadCount; ++i)
            {
                new HarmPart(i + 1, count, reported);
            }
        }
    }

    class HarmPart
    {
        private uint start;
        private ulong count;
        private ReportResultPart reportDone;
        public HarmPart(uint start,ulong count, ReportResultPart reportDone)
        {
            this.start = start;
            this.count = count;
            this.reportDone = reportDone;
            new Thread(run).Start();
        }
        private void run()
        {
            double part = 0;
            for (uint i = start; i < count; i+= HarmSum.ThreadCount) part += 1.0 / i;
            reportDone(part);
        }
    }
}
