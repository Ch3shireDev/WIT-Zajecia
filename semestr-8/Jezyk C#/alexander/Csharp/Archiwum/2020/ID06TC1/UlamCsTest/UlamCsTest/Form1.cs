using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UlamCsTest
{
    public partial class Form1 : Form
    {
        private int count;
        public Form1()
        {
            InitializeComponent();
            EdCount.Text = 100.ToString();
        }

        private void EdCount_TextChanged(object sender, EventArgs e)
        {
            BtnDraw.Enabled = int.TryParse(EdCount.Text, out count);
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            PbUlam.Image = Ulam.make(count);
        }
    }
}
