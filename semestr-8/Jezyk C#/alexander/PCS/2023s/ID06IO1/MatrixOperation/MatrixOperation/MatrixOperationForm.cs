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
            ScLeft.SplitterWidth = 8;
            ScRight.SplitterWidth = 8;
        }

        private void ScLeft_SplitterMoved(object sender, SplitterEventArgs e)
        {
            ScRight.SplitterDistance = ScLeft.SplitterDistance;
        }

        private void ScRight_SplitterMoved(object sender, SplitterEventArgs e)
        {
            ScLeft.SplitterDistance = ScRight.SplitterDistance;
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            Matrix MatrixA;
            if (Matrix.TryParse(TbMatrixA.Text.Trim(), out MatrixA)) TbMatrixM.Text = MatrixA.ToString();
            else TbMatrixM.Text = "Parse error";
        }
    }
}
