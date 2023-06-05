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
    public partial class SimpleCalculatorMainForm : Form
    {
        public SimpleCalculatorMainForm()
        {
            InitializeComponent();
            CbOperation.Items.AddRange(OperationFactory.keys);
            CbOperation.SelectedIndex = 0;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double a = 5, b = 3;
            string op = CbOperation.SelectedItem.ToString();
            double r = OperationFactory.calculate(a, op, b);
            TbResult.AppendText($"{a} {op} {b} = {r}"+Environment.NewLine);
        }
    }
}
