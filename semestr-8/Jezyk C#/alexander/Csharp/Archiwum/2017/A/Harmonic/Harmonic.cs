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
    public partial class Harmonic : Form
    {
        delegate void AppendStringProc(string str);
        private long Count;
        public Harmonic()
        {
            InitializeComponent();
            EdCount_TextChanged(null, null);
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            new HarmonicCalc(Count, HarmonicCalcProc);
            EdCount.SelectAll();
            EdCount.Focus();
        }

        private void EdCount_TextChanged(object sender, EventArgs e)
        {
            BtnCalc.Enabled = long.TryParse(EdCount.Text, out Count);
        }

        private void AppendString(string str)
        {
            Results.AppendText(str);
        }

        private void AppendStringInvoke(string str)
        {
            Invoke(new AppendStringProc(AppendString), new Object[] { str });
        }

        private void HarmonicCalcProc(long Count)
        {
            double sum = 0;
            for (long i = 1; i <= Count; ++i) sum += 1.0 / i;
            AppendStringInvoke(Count.ToString() + ": " + sum.ToString() + Environment.NewLine);
        }
    }
}
