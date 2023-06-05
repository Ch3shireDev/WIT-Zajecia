using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test019
{
    public partial class Form1 : Form
    {
        private double[] sum = new double[4];
        private uint count;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (bw1.IsBusy) return;
            if (bw2.IsBusy) return;
            if (bw3.IsBusy) return;
            if (bw4.IsBusy) return;
            if (uint.TryParse(Count.Text, out count))
            {
                Value.ForeColor = SystemColors.WindowText;
                sum[0] = sum[1] = sum[2] = sum[3] = 0;
                bw1.RunWorkerAsync();
                bw2.RunWorkerAsync();
                bw3.RunWorkerAsync();
                bw4.RunWorkerAsync();
            }
            else
            {
                Value.Text = "Error";
                Value.ForeColor = Color.Red;
            }
        }

        private void bw1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (uint i = 1; i <= count; i += 4) sum[0] += 1.0 / i;
        }

        private void bw2_DoWork(object sender, DoWorkEventArgs e)
        {
            for (uint i = 2; i <= count; i += 4) sum[1] += 1.0 / i;
        }

        private void bw3_DoWork(object sender, DoWorkEventArgs e)
        {
            for (uint i = 3; i <= count; i += 4) sum[2] += 1.0 / i;
        }

        private void bw4_DoWork(object sender, DoWorkEventArgs e)
        {
            for (uint i = 4; i <= count; i += 4) sum[3] += 1.0 / i;
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Value.Text = string.Format("{0:#.000000000000}", sum[0] + sum[1] + sum[2] + sum[3]);
        }
    }
}
