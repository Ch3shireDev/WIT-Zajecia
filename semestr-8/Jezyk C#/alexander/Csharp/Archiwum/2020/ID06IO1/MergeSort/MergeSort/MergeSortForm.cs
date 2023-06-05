using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeSort
{
    public partial class MergeSortForm : Form
    {
        public MergeSortForm()
        {
            InitializeComponent();
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            double[] tb = ArrayHelper.ParseArray(EdSource.Text);
            MergeSort.Sort(tb);
            EdResult.Text = ArrayHelper.ToString(tb);
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            EdSource.Text = ArrayHelper.ToString(ArrayHelper.Generate(1000));
        }
    }
}
