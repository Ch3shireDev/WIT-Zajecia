using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarmonicCalc
{
    public delegate void AppendLogProc(string method,ulong count,double sum);
    public partial class HarmonicCalcForm : Form
    {
        private ulong count=100000000;
        public HarmonicCalcForm()
        {
            InitializeComponent();
            txtCount.Text=count.ToString();
        }
        private void AppendLog(string method,ulong count,double sum)
        {
            if(InvokeRequired) Invoke(new AppendLogProc(AppendLog),method,count,sum);
            else txtLog.AppendText(string.Format("{0} - {1,15}: {2:F18}",method,count,sum)+Environment.NewLine);
        }
        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            btnCalc.Enabled=ulong.TryParse(txtCount.Text,out count);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            new HarmonicCalcThread(count, AppendLog).calc();
            new HarmonicCalcMulti(count, AppendLog).calc();
            //new HarmonicCalcSimple(count,AppendLog).calc();
            //new HarmonicCalcThread(count, AppendLog).calc();
        }
    }
}
