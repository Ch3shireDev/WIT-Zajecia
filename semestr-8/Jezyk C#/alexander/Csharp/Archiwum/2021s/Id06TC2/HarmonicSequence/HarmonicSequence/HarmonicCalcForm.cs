using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarmonicSequence
{
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
            if(InvokeRequired) Invoke(new ReportResult(AppendLog),new object[] { method,count,sum });
            else txtLog.AppendText(string.Format("{0} {1}: {2:F18}",method,count,sum)+Environment.NewLine);
        }
        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            bool goodCount=ulong.TryParse(txtCount.Text,out count);
            btnSimple.Enabled=goodCount;
        }
        private void btnSimple_Click(object sender, EventArgs e)
        {
            new HarmonicCalcMultiThread(count,AppendLog).calc();
        }

    }
}
