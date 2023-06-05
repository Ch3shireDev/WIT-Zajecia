using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void foo(out int x)
        {
            x = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y;
            foo(out y);
            if(Int32.TryParse(textBox1.Text,out y))
            {

            }
            else
            {

            }
        }
    }
}
