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

namespace Threads
{
    delegate void AppendValueProc(string Mark, ulong Count, double Result);
    public partial class CharmonicSequence : Form
    {
        private static readonly ulong ThreadCount = 4;
        private ulong Count = 100000000;
        public CharmonicSequence()
        {
            InitializeComponent();
            EdCount.Text = Count.ToString();
        }

        private double Harm(ulong Count)
        {
            double sum = 0;
            for (ulong i = 1; i <= Count; ++i) sum += 1D / i; // 1,/i; 1.0/i; 1D/i; ((double)1)/i; 1/(double)i;
            return sum;
        }

        private double MultiCalculatePart(ulong Start, ulong Count)
        {
            double sum = 0;
            for (ulong i = Start + 1; i <= Count; i += ThreadCount) sum += 1D / i;
            return sum;
        }

        private void AppendText(string Mark, ulong Count, double Result)
        {
            if (InvokeRequired) Invoke(new AppendValueProc(AppendText), new object[] { Mark, Count, Result });
            else EdLog.AppendText(string.Format("{0} {1}: {2:F18}", Mark, Count, Result) + Environment.NewLine);
        }

        private void Calculate(string Method,ulong Count)
        {
            double Result = Harm(Count);
            AppendText(Method, Count, Result);
        }

        private void MultiCalculate(ulong Count)
        {
            Thread[] th = new Thread[ThreadCount];
            double[] Results = new double[ThreadCount];
            for (ulong i = 0; i < ThreadCount; ++i)
            {
                ulong Start = i;
                th[i] = new Thread(() => Results[Start] = MultiCalculatePart(Start, Count));
            }
            foreach (Thread t in th) t.Start();
            foreach (Thread t in th) t.Join();
            double Result = 0;
            foreach (double v in Results) Result += v;
            AppendText("m", Count, Result);
        }

        private void MultiLockCalculate(ulong Count)
        {
            Thread[] th = new Thread[ThreadCount];
            double Result = 0;
            for (ulong i = 0; i < ThreadCount; ++i)
            {
                ulong Start = i;
                th[i] = new Thread
                (
                    () => 
                    {
                        double add = MultiCalculatePart(Start, Count);
                        lock (th)
                        {
                            Result += add;
                        }
                    }
                );
            }
            foreach (Thread t in th) t.Start();
            foreach (Thread t in th) t.Join();
            AppendText("l", Count, Result);
        }

        private void MultiAtomicCalculate(ulong Count)
        {
            Thread[] th = new Thread[ThreadCount];
            /*
            Atomic<double> Result = 0;
            for (ulong i = 0; i < ThreadCount; ++i)
            {
                ulong Start = i;
                th[i] = new Thread ( Result += MultiCalculatePart(Start, Count) );
            }
            foreach (Thread t in th) t.Start();
            foreach (Thread t in th) t.Join();
            AppendText("l", Count, Result.get());
            */
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            EdCount.SelectAll();
            EdCount.Focus();
            Calculate("s",Count);
        }

        private void BTnThreadCalculate_Click(object sender, EventArgs e)
        {
            EdCount.SelectAll();
            EdCount.Focus();
            Thread th = new Thread(() => Calculate("t",Count));
            th.Start();
        }
        private void BTnMultiThreadCalculate_Click(object sender, EventArgs e)
        {
            EdCount.SelectAll();
            EdCount.Focus();
            Thread th = new Thread(() => MultiCalculate(Count));
            th.Start();
        }

        private void BtnMultiLockCalculate_Click(object sender, EventArgs e)
        {
            EdCount.SelectAll();
            EdCount.Focus();
            Thread th = new Thread(() => MultiLockCalculate(Count));
            th.Start();
        }

        private void BtnAtomicCalculate_Click(object sender, EventArgs e)
        {
            EdCount.SelectAll();
            EdCount.Focus();
            Thread th = new Thread(() => MultiAtomicCalculate(Count));
            th.Start();
        }

        private void EdCount_TextChanged(object sender, EventArgs e)
        {
            BtnCalculate.Enabled = ulong.TryParse(EdCount.Text, out Count);
        }
    }
}