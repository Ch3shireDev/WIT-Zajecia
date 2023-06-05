using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ulam
{
    public partial class UlamForm : Form
    {
        private int count=100;
        public UlamForm()
        {
            InitializeComponent();
            TbCount.Text = count.ToString();
        }
        private void BtnRun_Click(object sender, EventArgs e)
        {
            PbUlam.Image = UlamHelper.makeBitmap(count);
        }

        private void TbCount_TextChanged(object sender, EventArgs e)
        {
            BtnRun.Enabled = int.TryParse(TbCount.Text, out count);
        }
    }
}