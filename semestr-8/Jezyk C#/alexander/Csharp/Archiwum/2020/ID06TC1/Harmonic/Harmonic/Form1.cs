using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harmonic
{
    public partial class Form1 : Form
    {
        private long Count = 100000000;
        public Form1()
        {
            InitializeComponent();
            EdCount.Text = Count.ToString();
        }

        private void EdCount_TextChanged(object sender, EventArgs e)
        {
            BtnCalc.Enabled = long.TryParse(EdCount.Text, out Count);
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (long i = 1; i <= Count; ++i) sum += 1d / i;
            EdLog.AppendText(string.Format("{0:F18}", sum) + Environment.NewLine);
            EdCount.SelectAll();
            EdCount.Focus();
        }
    }
}
