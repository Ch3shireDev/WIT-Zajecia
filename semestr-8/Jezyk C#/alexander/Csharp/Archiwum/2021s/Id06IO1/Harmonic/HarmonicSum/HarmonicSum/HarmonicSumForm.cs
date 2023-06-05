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

namespace HarmonicSum
{
    delegate void AppendLogProc(string text);
    public partial class HarmonicSumForm : Form
    {
        private readonly static int ThreadCount=4;
        private ulong count=100000000;
        public HarmonicSumForm()
        {
            InitializeComponent();
            txtCount.Text=count.ToString();
        }

        private void AppendLog(string text)
        {
            if (InvokeRequired) Invoke(new AppendLogProc(AppendLog), new object[] { text });
            else txtLog.AppendText(text+Environment.NewLine);
        }
        private void AppendLog(string method,ulong count,double sum)
        {
            AppendLog(string.Format("{0}/{1}: {2:F18}",method,count,sum));
        }
        private void SimpleCalc(ulong cnt,string method)
        {
            double sum;            
            HarmonicSum.sum(cnt,out sum);
            AppendLog(method,cnt,sum);
        }
        private void OneThreadCalc()
        {
            SimpleCalc(count,"o");
        }
        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            btnSimple.Enabled=ulong.TryParse(txtCount.Text,out count);
        }
        private void btnSimple_Click(object sender, EventArgs e)
        {
            SimpleCalc(count,"s");
        }
        private void btnOneThread_Click(object sender, EventArgs e)
        {
            Thread th=new Thread(OneThreadCalc);
            th.Start();
        }

        private void MultiCalc(ulong cnt,int start,double[] res)
        {
            HarmonicSum.sum(cnt,start,ThreadCount,out res[start]);
        }
        private void MultiCalc(object par)
        {
            object[] tb=(object[])par;
            int start=(int)tb[0];
            ulong cnt=(ulong)tb[1];
            double[] res=(double[])tb[2];
            MultiCalc(cnt,start,res);
        }

        private void MultiCalcThread()
        {
            ulong cnt = count;
            double[] res = new double[ThreadCount];
            Thread[] th = new Thread[ThreadCount];
            for (int i = 0; i < ThreadCount; ++i) th[i] = new Thread(MultiCalc);
            for (int i = 0; i < ThreadCount; ++i) th[i].Start(new object[] { i, cnt, res });
            for (int i = 0; i < ThreadCount; ++i) th[i].Join();
            double sum = 0;
            for (int i = 0; i < ThreadCount; ++i) sum += res[i];
            AppendLog("m", cnt, sum);
        }

        private void btnMultiThread_Click(object sender, EventArgs e)
        {
            new Thread(MultiCalcThread).Start();
        }
    }
}
