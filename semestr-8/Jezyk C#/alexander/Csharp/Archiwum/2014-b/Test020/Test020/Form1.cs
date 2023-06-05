using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Test020
{
    public partial class Form1 : Form
    {
        private Thread[] th = new Thread[4];
        private double[] sum = new double[4];
        public Form1()
        {
            InitializeComponent();
        }

        private void ThCalc(uint start, uint count)
        {
            double ss = 0;
            for (uint i = start+1; i <= count; i += 4) ss += 1.0 / i;
            sum[start] = ss;
        }

        private void ThCalcObj(object param)
        {
            object[] ptb = (object[])param;
            ThCalc((uint)ptb[0],(uint)ptb[1]);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            uint count;
            if (uint.TryParse(Count.Text, out count))
            {
                Value.ForeColor = SystemColors.WindowText;
                for (uint i = 0; i < th.Length; ++i) th[i] = new Thread(ThCalcObj);
                for (uint i = 0; i < th.Length; ++i) th[i].Start(new object[] { i,count });
                for (uint i = 0; i < th.Length; ++i) th[i].Join();
                Value.Text = string.Format("{0:#.000000000000}", sum[0] + sum[1] + sum[2] + sum[3]);
            }
            else
            {
                Value.Text = "Error";
                Value.ForeColor = Color.Red;
            }
        }
    }
}
