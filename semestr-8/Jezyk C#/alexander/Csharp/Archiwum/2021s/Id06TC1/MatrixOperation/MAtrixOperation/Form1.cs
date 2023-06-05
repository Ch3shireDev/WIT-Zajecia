using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAtrixOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Matrix a = Matrix.Parse(TxtA.Text);
            Matrix b = Matrix.Parse(TxtB.Text);
            Matrix c = a + b;
            TxtC.Text = c.ToString();
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            Matrix a = Matrix.Parse(TxtA.Text);
            Matrix b = Matrix.Parse(TxtB.Text);
            Matrix c = a * b;
            TxtC.Text = c.ToString();
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            Matrix a = Matrix.Parse(TxtA.Text);
            Matrix b = Matrix.Parse(TxtB.Text);
            Matrix c = a - b;
            TxtC.Text = c.ToString();
        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            Matrix m = Matrix.Parse(TxtA.Text);
            Matrix y = Matrix.Parse(TxtC.Text);

            TxtB.Text = Matrix.solve(m, y).ToString();
        }
    }
}
