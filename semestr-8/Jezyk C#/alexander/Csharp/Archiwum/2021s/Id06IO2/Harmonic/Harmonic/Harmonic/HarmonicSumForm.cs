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

namespace Harmonic
{
    delegate void AppendLogProc(string str);
    public partial class HarmonicSumForm : Form
    {
        private readonly static int ThreadCount=4;
        private ulong count;
        public HarmonicSumForm()
        {
            InitializeComponent();
            txtCount_TextChanged(null,null);
        }
        private void AppendLog(string str)
        {
            if(InvokeRequired) Invoke(new AppendLogProc(AppendLog),new object[] { str });
            else txtLog.AppendText(str);
        }
        private void AppendLog(ulong count,double sum,string src)
        {
            string str=string.Format("{0}/{1}: {2:F18}",src,count,sum)+Environment.NewLine;
            AppendLog(str);
        }
        private void SimpleSum(string src)
        {
            AppendLog(count,HarmonicSumBase.sum(count),src);
        }
        private void OneThreadSum() { SimpleSum("o"); }
             
        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            btnSimple.Enabled=ulong.TryParse(txtCount.Text,out count);
        }
        private void btnSimple_Click(object sender, EventArgs e)
        {
            SimpleSum("s");
        }

        private void btnThread_Click(object sender, EventArgs e)
        {
            Thread th=new Thread(OneThreadSum);
            th.Start();
        }

        private void calcsum(object obj)
        {
            object[] par=(object[])obj;
            double[] tb=(double[])par[0];
            ulong count=(ulong)par[1];
            int start=(int)par[2];
            HarmonicSumBase.sum(tb,count,(ulong)start,(ulong)ThreadCount);
        }

        private void btnMultiThread_Click(object sender, EventArgs e)
        {
            double[] tb = new double[ThreadCount];
            Thread[] th=new Thread[ThreadCount];
            for (int i = 0; i < ThreadCount; ++i) th[i] = new Thread(new ParameterizedThreadStart(calcsum));
            for(int i=0;i<ThreadCount;++i) th[i].Start(new object[] { tb,count,i });
            for(int i=0;i<ThreadCount;++i) th[i].Join();
            double result=0;
            for(int i=0;i<ThreadCount;++i) result+=tb[i];
            AppendLog(count,result,"m");
        }
    }
}
