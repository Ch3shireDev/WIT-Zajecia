using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UlamClasterTest
{
    public partial class UlamClusterForm : Form
    {
        private int number;
        public UlamClusterForm()
        {
            InitializeComponent();
            EdNumber.Text = "100";
        }

        private void EdNumber_TextChanged(object sender, EventArgs e)
        {
            BtnCalc.Enabled = int.TryParse(EdNumber.Text, out number);
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            Box.Image = UlamCluster.Make(number);
        }
    }
}
