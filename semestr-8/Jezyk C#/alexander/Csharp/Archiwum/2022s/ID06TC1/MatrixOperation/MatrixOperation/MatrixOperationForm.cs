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
    public partial class MatrixOperationForm : Form
    {
        public MatrixOperationForm()
        {
            InitializeComponent();
        }

        private void SpLeft_SplitterMoved(object sender, SplitterEventArgs e)
        {
            SpRight.SplitterDistance = SpLeft.SplitterDistance;
        }

        private void SpRight_SplitterMoved(object sender, SplitterEventArgs e)
        {
            SpLeft.SplitterDistance = SpRight.SplitterDistance;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //Matrix a = Matrix.parse(TbMatrixA.Text);
            //Matrix b = Matrix.parse(TbMatrixB.Text);
            //TbMatrixResult.Text = (a + b).toString();
        }
    }
}
