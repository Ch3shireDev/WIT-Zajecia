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
        private InputControlerDouble ControlerOperandA, ControlerOperandB;
        public SimpleCalculatorMainForm()
        {
            InitializeComponent();
            CbOperation.Items.AddRange(OperationFactory.keys);
            CbOperation.SelectedIndex = 0;
            ControlerOperandA = new InputControlerDouble(TbOperandA, this_callback, 0);
            ControlerOperandB = new InputControlerDouble(TbOperandB, this_callback, 0);
            this_callback(null);
        }
        private void this_callback(InputControler sender)
        {
            BtnCalculate.Enabled
            =
                ControlerOperandA != null &&
                ControlerOperandB != null &&
                ControlerOperandA.Good &&
                ControlerOperandB.Good &&
                true
            ;
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double a = double.Parse(TbOperandA.Text.Trim());
            double b = double.Parse(TbOperandB.Text.Trim());
            // init in constructor no chance for null
            string op = CbOperation.SelectedItem.ToString();
            double result = OperationFactory.calculate(a, op, b);
            TbResults.AppendText($"{a} {op} {b} = {result}"+Environment.NewLine);
        }
    }
}
