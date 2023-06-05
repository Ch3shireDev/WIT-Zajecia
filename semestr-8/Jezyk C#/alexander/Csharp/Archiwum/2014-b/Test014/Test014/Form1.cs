using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test014
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Operation.Items.Add(new OpAddition());
            Operation.Items.Add(new OpSubstraction());
            Operation.Items.Add(new OpMultiplication());
            Operation.Items.Add(new OpDivision());
            Operation.SelectedIndex = 0;
        }

        private void Operation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(ValueA.Text), b = double.Parse(ValueB.Text);
                OpBase op = (OpBase)Operation.SelectedItem;
                double c = op.calc(a, b);
                ResultValue.Text = c.ToString();
            }
            catch (Exception ex)
            {
                ResultValue.Text = ex.Message;
            }
        }
    }

    public abstract class OpBase
    {
        public abstract double calc(double a, double b);
    }
    public class OpAddition : OpBase
    {
        public override double calc(double a, double b)
        {
            return a + b;
        }
        public override string ToString()
        {
            return "Add";
        }
    }
    public class OpSubstraction : OpBase
    {
        public override double calc(double a, double b)
        {
            return a - b;
        }
        public override string ToString()
        {
            return "Sub";
        }
    }
    public class OpMultiplication : OpBase
    {
        public override double calc(double a, double b)
        {
            return a * b;
        }
        public override string ToString()
        {
            return "Mul";
        }
    }
    public class OpDivision : OpBase
    {
        public override double calc(double a, double b)
        {
            return a / b;
        }
        public override string ToString()
        {
            return "Div";
        }
    }
}
