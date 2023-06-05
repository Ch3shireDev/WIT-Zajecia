using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class SimpleCalculatorMain : Form
    {
        private double valueA, valueB;
        public SimpleCalculatorMain()
        {
            InitializeComponent();
        }

        private void adjustButton()
        {
            BtnCalculate.Enabled
            =
                (TbValueA.BackColor == SystemColors.Window)
                &&
                (TbValueB.BackColor == SystemColors.Window)
            ;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            /*
            double a = double.Parse(TbValueA.Text);
            double b = double.Parse(TbValueB.Text);
            TbResult.Text = (a + b).ToString();
            */
            TbResult.Text = (valueA + valueB).ToString();
        }

        private void TbValueA_TextChanged(object sender, EventArgs e)
        {
            bool ok=double.TryParse(TbValueA.Text, out valueA);
            TbValueA.BackColor = ok ? SystemColors.Window : Color.Yellow;
            adjustButton();
        }

        private void TbValueB_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(TbValueB.Text, out valueB))
            {
                TbValueB.BackColor = SystemColors.Window;
            }
            else
            {
                TbValueB.BackColor = Color.Yellow;
            }
            adjustButton();
        }
    }
}
