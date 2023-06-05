using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeThreadTest
{
    public partial class MergeSortForm : Form
    {
        public MergeSortForm()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            int[] Src = new int[] { 11, 12, 34, 7, 8, 99, 1 };
            int[] Dst = Merge.Sort(Src);
            return;
        }
    }
}
