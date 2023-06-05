using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CaptionClick(CaptionAdd,null);
        }

        private void ValueChange(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(ValueA.Text, out a) && double.TryParse(ValueB.Text, out b))
            {
                ResultAdd.Text = string.Format("{0:0.#}", a + b);
                ResultSub.Text = string.Format("{0:0.#}", a - b);
                ResultMul.Text = string.Format("{0:0.#}", a * b);
                ResultDiv.Text = string.Format("{0:0.#}", a / b);
            }
            else ResultAdd.Text = "Error";
        }

        private void ValueEnter(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.SelectAll();
        }

        private void CaptionClick(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            int T = int.Parse((string)lbl.Tag);
            CaptionAdd.ForeColor = (T == 0) ? Color.Red : SystemColors.WindowText;
            ResultAdd.ForeColor = (T == 0) ? Color.Red : SystemColors.WindowText;
            CaptionSub.ForeColor = (T == 1) ? Color.Red : SystemColors.WindowText;
            ResultSub.ForeColor = (T == 1) ? Color.Red : SystemColors.WindowText;
            CaptionMul.ForeColor = (T == 2) ? Color.Red : SystemColors.WindowText;
            ResultMul.ForeColor = (T == 2) ? Color.Red : SystemColors.WindowText;
            CaptionDiv.ForeColor = (T == 3) ? Color.Red : SystemColors.WindowText;
            ResultDiv.ForeColor = (T == 3) ? Color.Red : SystemColors.WindowText;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) { ValueA.Focus(); e.Handled = true; }
            else if (e.KeyValue == (char)2) { ValueB.Focus(); e.Handled = true; }
            else if (e.KeyValue == '+') { CaptionClick(CaptionAdd, null); e.Handled = true; }
            else if (e.KeyValue == '~') { CaptionClick(CaptionSub, null); e.Handled = true; }
            else if (e.KeyValue == '*') { CaptionClick(CaptionMul, null); e.Handled = true; }
            else if (e.KeyValue == '/') { CaptionClick(CaptionDiv, null); e.Handled = true; }
        }
    }
}
