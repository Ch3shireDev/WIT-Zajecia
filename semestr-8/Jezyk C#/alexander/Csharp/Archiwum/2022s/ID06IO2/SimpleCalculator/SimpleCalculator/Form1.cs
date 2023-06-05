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
        private DobleFieldControler ControlerA, ControlerB;
        public Form1()
        {
            InitializeComponent();
            ControlerA = new DobleFieldControler(0, TbValueA, Checker);
            ControlerB = new DobleFieldControler(0, TbValueB, Checker);
        }

        private void Checker()
        {
            BtnCalculate.Enabled = ((TbValueB.BackColor == SystemColors.Window) && (TbValueA.BackColor == SystemColors.Window));
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            TbResult.Text = (ControlerA.Value + ControlerB.Value).ToString();
        }
    }
}
