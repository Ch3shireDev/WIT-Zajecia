using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarmCalc
{
    delegate void DelegateAppendText(string value);
    public partial class HarmCalc : Form
    {
        public HarmCalc()
        {
            InitializeComponent();
        }

        private static double Calculate(uint cnt)
        {
            double sum = 0;
            for(uint i=1;i<=cnt;++i)
            {
                sum+=1.0/i;
            }
            return sum;
        }

        private void AppendText(string value)
        {
            LbResult.Text = LbResult.Text + Environment.NewLine + value;
            //BtnCalc.Enabled = true;
        }

        private void InvokeAppendText(string value)
        {
            Invoke(new DelegateAppendText(AppendText), new object[] { value });
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            //BtnCalc.Enabled = false;
            BackgroundWorker Worker = new BackgroundWorker();
            Worker.DoWork += Worker_DoWork;
            Worker.RunWorkerAsync(EdCount.Text);
            EdCount.Focus();
            EdCount.SelectAll();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string text = (string)e.Argument;
            uint cnt = 0;
            if (UInt32.TryParse(text, out cnt))
            {
                InvokeAppendText(text + ": " + Calculate(cnt).ToString());
            }
            else InvokeAppendText(text + ": ?");
        }
    }
}
