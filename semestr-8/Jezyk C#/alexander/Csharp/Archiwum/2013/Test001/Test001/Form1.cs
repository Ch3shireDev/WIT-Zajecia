using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test001
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
            Op.SelectedIndex = 0;
        }

        private void DataChanged(object sender, EventArgs e)
        {
            double A, B;
            bool fa = Double.TryParse(OpA.Text, out A);
            bool fb = Double.TryParse(OpB.Text, out B);
            if ((fa) && (fb))
            {
                switch (Op.SelectedIndex)
                {
                    case 0: Result.Text = String.Format("{0}", A + B); break;
                    case 1: Result.Text = String.Format("{0}", A - B); break;
                    case 2: Result.Text = String.Format("{0}", A * B); break;
                    case 3:
                        if (B != 0) Result.Text = String.Format("{0}", A / B);
                        else Result.Text = "Cholero, nie dziel przez zero.";
                        break;
                }
            }
            else
            {
                string s = "";
                if (!fa) s += "Pierwszy operand zły; ";
                if (!fb) s += "Drugi operand zły; ";
                Result.Text = s.Trim();
            }
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            int pos = box.SelectionStart, len = box.SelectionLength;
            string ns = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
            box.Text = box.Text.Replace(",", ns).Replace(".", ns);
            box.SelectionStart = pos;
            box.SelectionLength = len;
            DataChanged(sender, e);
        }
    }
}
