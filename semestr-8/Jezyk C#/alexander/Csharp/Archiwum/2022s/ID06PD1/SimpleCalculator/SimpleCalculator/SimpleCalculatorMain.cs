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
        private double ValueA=16, ValueB=2;
        public SimpleCalculatorMain()
        {
            InitializeComponent();
            TbValueA.Text = ValueA.ToString();
            TbValueB.Text = ValueB.ToString();
        }

        private void AdjustButton()
        {
            BtnCalculate.Enabled
            =
                (TbValueA.BackColor == SystemColors.Window)
                &&
                (TbValueB.BackColor == SystemColors.Window)
            ;
        }

        private void TbValueA_TextChanged(object sender, EventArgs e)
        {
            TbValueA.BackColor = double.TryParse(TbValueA.Text,out ValueA) ? SystemColors.Window : Color.Yellow;
            AdjustButton();
        }

        private void TbValueB_TextChanged(object sender, EventArgs e)
        {
            TbValueB.BackColor = double.TryParse(TbValueB.Text, out ValueB) ? SystemColors.Window : Color.Yellow;
            AdjustButton();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            TbResult.Text = (ValueA + ValueB).ToString();
        }
    }
}
