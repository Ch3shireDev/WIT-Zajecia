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
    delegate void AppendValueProc(string Mark,ulong Count,double Result);
    public partial class CharmonicSequence : Form
    {
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

        private void AppendText(string Mark, ulong Count, double Result)
        {
            if (InvokeRequired) Invoke(new AppendValueProc(AppendText), new object[] { Mark, Count, Result });
            else EdLog.AppendText(string.Format("{0} {1}: {2:F18}", Mark, Count, Result) + Environment.NewLine);
        }

        private void Calculate(ulong Count)
        {
            double Result = Harm(Count);
            AppendText("s", Count, Result);
        }

        private void CalculateCall(object obj)
        {
            object[] tb = (object[])obj;
            Calculate((ulong)tb[0]);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            EdCount.SelectAll();
            EdCount.Focus();
            //EdLog.AppendText(Count.ToString() + ": " + Harm(Count).ToString());
            Thread th = new Thread(new ParameterizedThreadStart(CalculateCall));
            th.Start(new object[] { Count });
        }

        private void BTnThreadCalculate_Click(object sender, EventArgs e)
        {
            new HarmCalc(Count, AppendText).Start();
        }

        private void EdCount_TextChanged(object sender, EventArgs e)
        {
            BtnCalculate.Enabled = ulong.TryParse(EdCount.Text, out Count);
        }
    }

    class HarmCalcPart
    {
        private ulong id, Count;
        private Thread th;
        private double result = 0;
        public HarmCalcPart(ulong id, ulong Count)
        {
            this.id = id;
            this.Count = Count;
            this.th = new Thread(Run);
        }
        public void Run()
        {
            double sum = 0;
            for (ulong i = id + 1; i <= Count; i += HarmCalc.ThreadCount) sum += 1D / i;
            result = sum;
        }
        public void Start() { th.Start(); }
        public void Join() { th.Join(); }
        public double Result() { return result; }
    }

    class HarmCalc
    {
        public static readonly ulong ThreadCount = 4;
        private ulong Count;
        private AppendValueProc proc;
        private Thread th;
        public HarmCalc(ulong Count, AppendValueProc proc)
        {
            this.Count = Count;
            this.th = new Thread(Run);
            this.proc = proc;
        }
        public void Run()
        {
            HarmCalcPart[] th = new HarmCalcPart[ThreadCount];
            for (ulong t = 0; t < ThreadCount; ++t) th[t] = new HarmCalcPart(t, Count);
            for (ulong t = 0; t < ThreadCount; ++t) th[t].Start();
            for (ulong t = 0; t < ThreadCount; ++t) th[t].Join();
            double Result = 0;
            for (ulong t = 0; t < ThreadCount; ++t) Result += th[t].Result();
            proc("m", Count, Result);
        }
        public void Start() { th.Start(); }
    }
}