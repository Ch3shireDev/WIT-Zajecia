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

namespace HarmCalcTest
{
    delegate void AppendLogProc(string Text);
    public partial class HarmSequenceForm : Form
    {
        private static readonly ulong ThreadCount=4;
        private ulong Count = 100000000;
        public HarmSequenceForm()
        {
            InitializeComponent();
            EdCount.Text = Count.ToString();
        }

        private void EdCount_TextChanged(object sender, EventArgs e)
        {
            BtnCalculate.Enabled = ulong.TryParse(EdCount.Text, out Count);
        }

        /// 1 5 9
        /// 2 6 10
        /// 3 7 11
        /// 4 8 12

        private static double CalcPartAlt(ulong id, ulong Count)
        {
            double sum = 0;
            for (ulong i = id + 1; i <= Count; i += ThreadCount) sum += 1.0 / i; // 1.0/i; 1D/i; 1/(double)i;
            return sum;
        }
        /*
        private static void CalcPart(ulong id, ulong Count, double[] tb)
        {
            double sum = 0;
            for (ulong i = id + 1; i <= Count; i += (ulong)tb.Length) sum += 1.0 / i; // 1.0/i; 1D/i; 1/(double)i;
            tb[id] = sum;
        }
        private static void CalcPartObj(object obj)
        {
            object[] tb = (object[])obj;
            CalcPart((ulong)tb[0], (ulong)tb[1], (double[])tb[2]);
        }
        */
        private void CalcMultiThread(ulong Count)
        {
            double[] result = new double[ThreadCount];
            Thread[] tb = new Thread[ThreadCount];
            for (ulong t = 0; t < ThreadCount; ++t)
            {
                ulong s = t;
                tb[t] = new Thread(() => result[s] = CalcPartAlt(s, Count));
            }
            for (ulong t = 0; t < ThreadCount; ++t) tb[t].Start();
            //for (ulong t = 0; t < ThreadCount; ++t) tb[t] = new Thread(CalcPartObj);
            //for (ulong t = 0; t < ThreadCount; ++t) tb[t].Start(new object[] { t, Count, result });
            for (ulong t = 0; t < ThreadCount; ++t) tb[t].Join();
            double sum = 0;
            for (ulong t = 0; t < ThreadCount; ++t) sum+=result[t];
            AppendLog(string.Format("m {0}: {1:F18}", Count, sum));
        }

        private void CalcMultiLockThread(ulong Count)
        {
            double sum = 0;
            Thread[] tb = new Thread[ThreadCount];
            for (ulong t = 0; t < ThreadCount; ++t)
            {
                ulong s = t;
                tb[t] = new Thread(() => { lock (tb) { sum += CalcPartAlt(s, Count); } } );
            }
            foreach (Thread t in tb) t.Start();
            foreach (Thread t in tb) t.Join();
            AppendLog(string.Format("l {0}: {1:F18}", Count, sum));
        }
        /*
        private void CalcMultiThreadObj(object obj)
        {
            ulong Count = (ulong)obj;
            double result = CalcMultiThread(Count);
            AppendLog(string.Format("m {0}: {1:F18}", Count, result));
        }
        */
        private static double Calc(ulong Count) // 1/1 + 1/2 + 1/3 ... 1/Count
        {
            double sum = 0;
            for (ulong i = 1; i <= Count; ++i) sum += 1.0 / i; // 1.0/i; 1D/i; 1/(double)i;
            return sum;
        }

        private void AppendLog(string Text)
        {
            if (InvokeRequired) Invoke(new AppendLogProc(AppendLog), new object[] { Text });
            else EdLog.AppendText(Text + Environment.NewLine);
        }

        private void InvokeAppendLog(string Text)
        {
            Invoke(new AppendLogProc(AppendLog),new object[] { Text });
        }

        private void CalcOneThread()
        {
            ulong SelfCount = Count;
            AppendLog(string.Format("s {0}: {1:F18}", SelfCount, Calc(SelfCount)));
        }

        private void CalcOneThreadWithCount(ulong SelfCount)
        {
            AppendLog(string.Format("s {0}: {1:F18}", SelfCount, Calc(SelfCount)));
        }

        private void CalcOneThreadWithCountObj(object obj)
        {
            CalcOneThreadWithCount((ulong)obj);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            EdCount.SelectAll();
            EdCount.Focus();
            //EdLog.AppendText(string.Format("{0}: {1:F18}", Count, Calc(Count)) + Environment.NewLine);
            //Thread th = new Thread(CalcOneThread);
            //th.Start();
            Thread th = new Thread(new ParameterizedThreadStart(CalcOneThreadWithCountObj));
            //Thread th = new Thread(CalcOneThreadWithCountObj);
            th.Start(Count);
        }

        private void BtnMultiThreadCalculate_Click(object sender, EventArgs e)
        {
            EdCount.SelectAll();
            EdCount.Focus();
            //EdLog.AppendText(string.Format("{0}: {1:F18}", Count, Calc(Count)) + Environment.NewLine);
            //Thread th = new Thread(CalcOneThread);
            //th.Start();
            Thread th = new Thread(() => CalcMultiThread(Count));
            th.Start();
        }

        private void BtnMultiLockCalculate_Click(object sender, EventArgs e)
        {
            EdCount.SelectAll();
            EdCount.Focus();
            //EdLog.AppendText(string.Format("{0}: {1:F18}", Count, Calc(Count)) + Environment.NewLine);
            //Thread th = new Thread(CalcOneThread);
            //th.Start();
            Thread th = new Thread(() => CalcMultiLockThread(Count));
            th.Start();
        }
    }
}
