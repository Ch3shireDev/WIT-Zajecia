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
        private InputControlDouble IcA, IcB;
        public SimpleCalculatorMainForm()
        {
            InitializeComponent();
            CbOperation.Items.AddRange(OperationFactory.keys);
            CbOperation.SelectedIndex = 0;
            IcA = new InputControlDouble(TbOperandA, 0, textboxes_TextChanged);
            IcB = new InputControlDouble(TbOperandB, 0, textboxes_TextChanged);
        }
        private void textboxes_TextChanged(InputControl sender)
        {
            BtnCalculate.Enabled
            =
                IcA != null &&
                IcB != null &&
                IcA.Good &&
                IcB.Good &&
                true
            ;
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double a = IcA.Result;
            double b = IcB.Result;
            string op = CbOperation.SelectedItem.ToString();
            double result = OperationFactory.calculate(a, op, b);
            TbResults.AppendText($"{a} {op} {b} = {result}" + Environment.NewLine);
        }
    }
}
