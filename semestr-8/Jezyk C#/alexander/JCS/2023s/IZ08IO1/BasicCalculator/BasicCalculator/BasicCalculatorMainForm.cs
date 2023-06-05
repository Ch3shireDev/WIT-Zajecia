using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class BasicCalculatorMainForm : Form
    {
        public BasicCalculatorMainForm()
        {
            InitializeComponent();
            CbOperation.Items.AddRange(OperationFactory.keys);
            CbOperation.SelectedIndex = 0;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            string op=CbOperation.SelectedItem.ToString();
            double a = 3, b = 7;
            TbResults.AppendText($"{a} {op} {b} = {OperationFactory.calculate(a,op,b)}" + Environment.NewLine);
        }
    }
}
