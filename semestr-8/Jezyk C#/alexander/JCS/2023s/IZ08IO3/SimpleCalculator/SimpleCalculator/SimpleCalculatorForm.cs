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
    public partial class SimpleCalculatorForm : Form
    {
        private ValidatorDouble vdA;
        public SimpleCalculatorForm()
        {
            InitializeComponent();
            CbOperation.Items.AddRange(OperationFactory.Keys);
            CbOperation.SelectedIndex = 0;
            vdA = new ValidatorDouble(TbValueA, Form_Callback);
        }
        private void Form_Callback(Validator validator)
        {
            BtnCalculate.Enabled
            =

            ;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double a = 7, b = 3;
            string op = CbOperation.SelectedItem.ToString();
            double r = OperationFactory.calculate(a, op, b);
            TbResults.AppendText($"{a} {op} {b} = {r}" + Environment.NewLine);
        }
    }
}
