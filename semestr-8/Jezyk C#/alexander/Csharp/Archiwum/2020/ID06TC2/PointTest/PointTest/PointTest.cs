using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointTest
{
    public partial class PointTest : Form
    {
        public PointTest()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            EdLog.AppendText("Ala ma kota" + Environment.NewLine); // "\n"
            EdLog.AppendText("Ala ma kota" + Environment.NewLine); // "\n"
            EdLog.AppendText("Ala ma kota" + Environment.NewLine); // "\n"
            Point p = new Point("P", 3, 5);
            EdLog.AppendText(p + Environment.NewLine);
            p.Name = "P";
            p.Name = "abc";
            p.Name = "abc";

        }
    }
}
