using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public partial class MatrixOperation : Form
    {
        public MatrixOperation()
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

        private void SplLeft_SplitterMoved(object sender, SplitterEventArgs e)
        {
            SplRight.SplitterDistance = SplLeft.SplitterDistance;
        }

        private void SplRight_SplitterMoved(object sender, SplitterEventArgs e)
        {
            SplLeft.SplitterDistance = SplRight.SplitterDistance;
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            Matrix a = Matrix.Parse(TxtA.Text);
            Matrix b = Matrix.Parse(TxtB.Text);
            Matrix c = a * b;
            TxtC.Text = c.ToString();
        }
    }
}
