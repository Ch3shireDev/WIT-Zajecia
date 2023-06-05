using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //Matrix a = new Matrix(MatrixA.Text);
            //Matrix b = new Matrix(MatrixB.Text);
            //MatrixC.Text = Matrix.add(a, b).ToString();
            MatrixC.Text = (new Matrix(MatrixA.Text) + new Matrix(MatrixB.Text)).ToString();
        }

        private void SplitLeft_SplitterMoved(object sender, SplitterEventArgs e)
        {
            SplitRight.SplitterDistance = SplitLeft.SplitterDistance;
        }

        private void SplitRight_SplitterMoved(object sender, SplitterEventArgs e)
        {
            SplitLeft.SplitterDistance=SplitRight.SplitterDistance;
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            MatrixC.Text = (new Matrix(MatrixA.Text) * new Matrix(MatrixB.Text)).ToString();
        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            MatrixB.Text = Matrix.solve(new Matrix(MatrixA.Text) , new Matrix(MatrixC.Text)).ToString();
        }
    }
}
