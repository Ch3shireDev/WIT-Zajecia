using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z012
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            Operation.SelectedIndex = 0;
        }

        private void Operation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string C = "ERROR";
            try
            {
                double A = Double.Parse(ValueA.Text), B = Double.Parse(ValueB.Text);
                switch(Operation.SelectedIndex)
                {
                    case 0: C = (A + B).ToString(); break;
                    case 1: C = (A - B).ToString(); break;
                    case 2: C = (A * B).ToString(); break;
                    case 3: if (B != 0) C = (A / B).ToString(); else C = "ZERO DIVIDE"; break;
                }
            }
            catch(Exception ex)
            {
            }
            Result.Text = C;
        }
    }
}
