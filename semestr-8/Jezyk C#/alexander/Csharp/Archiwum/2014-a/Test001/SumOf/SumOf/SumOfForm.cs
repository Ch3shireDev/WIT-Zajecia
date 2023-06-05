using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumOf
{
    public partial class SumForm : Form
    {
        public SumForm()
        {
            InitializeComponent();
        }

        private void CountValue_TextChanged(object sender, EventArgs e)
        {
            int N = 0;
            if (int.TryParse(CountValue.Text, out N))
            {
                CountValue.ForeColor = System.Drawing.SystemColors.WindowText;
                BtnCalc.Enabled = true;
            }
            else
            {
                CountValue.ForeColor = Color.Red;
                BtnCalc.Enabled = false;
            }
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            int N = 0;
            if (int.TryParse(CountValue.Text, out N))
            {
                Progress.Maximum = N;
                int mod = (N & 0xFFFF);
                double Sum=0;
                for(int i=1;i<=N;++i)
                {
                    Sum+=1.0/i;
                    if ((i & 0xFFFF) == mod)
                    {
                        Progress.Value = i;
                        Progress.Refresh();
                    }
                }
                ResultValue.AppendText(CountValue.Text+" => "+Sum.ToString()+Environment.NewLine);
            }
            Progress.Value = 0;
            CountValue.SelectAll();
            CountValue.Focus();
        }
    }
}
