using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            OpnCalc x = new OpnCalc(Equ.Text);
            Equ.Focus();
            if (x.Ok)
            {
                Result.Text = x.Result.ToString();
                OnpHow.Text = x.Line;
                Equ.SelectAll();
            }
            else
            {
                Result.Text = "ERROR";
                OnpHow.Clear();
                Equ.SelectionStart = x.Pos-1;
                Equ.SelectionLength = 1;
            }
        }
    }
}