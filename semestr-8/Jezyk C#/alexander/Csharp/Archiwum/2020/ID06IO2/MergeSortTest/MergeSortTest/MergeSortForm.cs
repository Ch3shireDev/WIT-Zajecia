using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeSortTest
{
    public partial class MergeSortForm : Form
    {
        public MergeSortForm()
        {
            InitializeComponent();
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            double[] table = ArrayHelper.Parse(EdSource.Text);
            MergeSort.Sort(table);
            EdResult.Text = ArrayHelper.ToString(table);
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            EdSource.Text = ArrayHelper.ToString(ArrayHelper.Generate(1000));
        }
    }
}
