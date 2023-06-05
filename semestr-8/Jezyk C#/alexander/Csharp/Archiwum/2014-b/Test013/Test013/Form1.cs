using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test013
{
    public partial class Test013 : Form
    {
        delegate double CalcFun(double a,double b);
        private CalcFun fun;

        public Test013()
        {
            InitializeComponent();
            Operation.SelectedIndex = 0;
            //Operation_SelectedIndexChanged(this, null);
        }

        private double Add(double a,double b)
        {
            return a + b;
        }

        private double Sub(double a, double b)
        {
            return a - b;
        }

        private double Mul(double a, double b)
        {
            return a * b;
        }

        private double Div(double a, double b)
        {
            return a / b;
        }

        private void ABValue_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void ABValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ResultValue.Text
                =
                    fun
                    (
                        double.Parse(AValue.Text),
                        double.Parse(BValue.Text)
                    ).ToString()
                ;
            }
            catch (Exception)
            {
                ResultValue.Text = "ERR";
            }
            //AValue.SelectAll();
            //AValue.Focus();
        }

        private void Operation_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(Operation.SelectedIndex)
            {
                case 0: fun = Add; break;
                case 1: fun = Sub; break;
                case 2: fun = Mul; break;
                case 3: fun = Div; break;
            }
            ABValue_TextChanged(sender, e);
        }
    }

    class OperationFun
    {
        //public override string ToString();
        public abstract double fun(double a,double b);
    }
}
