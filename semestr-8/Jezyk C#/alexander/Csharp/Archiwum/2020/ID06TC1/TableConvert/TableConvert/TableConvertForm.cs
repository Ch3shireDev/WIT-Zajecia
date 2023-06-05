using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableConvert
{
    public partial class TableConvertForm : Form
    {
        public TableConvertForm()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            double[,] mat = ArrayHelper.ParseMatrix(EdMatrix.Text);
            double[] vec = ArrayHelper.ParseVector(EdParams.Text);
            double[] ret = ArrayHelper.MatrixMulVector(mat, vec);
            EdResult.Text = ArrayHelper.VectorToRows(ret);
        }

        private void PButtons_Resize(object sender, EventArgs e)
        {
            EdMatrix.Width = PButtons.Width;
        }

        private void EdMatrix_Resize(object sender, EventArgs e)
        {
            PButtons.Width = EdMatrix.Width;
        }

    }
}
