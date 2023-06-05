using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace z013
{
    public partial class Form1 : Form
    {
        bool StartNumber = true;
        string operation = "=";
        double SaveValue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            if (StartNumber) Value.Text = "";
            Value.Text += ((Button)sender).Text;
            StartNumber = false;
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            if (StartNumber) Value.Text = "0";
            if (!Value.Text.Contains('.')) Value.Text += ((Button)sender).Text;
            StartNumber = false;
        }

        private void BtnOpr_Click(object sender, EventArgs e)
        {
            double NextValue = Double.Parse(Value.Text.Replace('.', Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)));
            if (!StartNumber)
            {
                switch(operation[0])
                {
                    case '+': SaveValue += NextValue; break;
                    case '-': SaveValue -= NextValue; break;
                    case '*': SaveValue *= NextValue; break;
                    case '/': SaveValue /= NextValue; break;
                    default:  SaveValue = NextValue; break;
                }
                Value.Text = SaveValue.ToString();
            }
            operation = ((Button)sender).Text;
            StartNumber = true;
        }

        private void Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            string ch = e.KeyChar.ToString();
            if ((ch == "\b") && (!StartNumber))
            {
                if (Value.Text.Length > 1) Value.Text = Value.Text.Substring(0,Value.Text.Length-1);
                else
                {
                    Value.Text = "0";
                    StartNumber = true;
                }
                return;
            }
            if (ch == "\r") ch = "=";                
            foreach (Control cr in Table.Controls)
            {
                if (((Button)cr).Text == ch)
                {
                    ((Button)cr).PerformClick();
                    break;
                }
            }
        }
    }
}
