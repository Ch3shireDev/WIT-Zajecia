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
    public partial class Form1 : Form
    {
        DoubleFieldManager ValueA, ValueB;
        public Form1()
        {
            InitializeComponent();
            ValueA = new DoubleFieldManager(0, TbValueA, AdjustButtons);
            ValueB = new DoubleFieldManager(0, TbValueB, AdjustButtons);
        }

        private void AdjustButtons()
        {
            btnCalculate.Enabled
            =
                (TbValueA.BackColor == SystemColors.Window)
                &&
                (TbValueB.BackColor == SystemColors.Window)
            ;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            TbResult.Text = (ValueA.Value + ValueB.Value).ToString();
        }
    }
}
