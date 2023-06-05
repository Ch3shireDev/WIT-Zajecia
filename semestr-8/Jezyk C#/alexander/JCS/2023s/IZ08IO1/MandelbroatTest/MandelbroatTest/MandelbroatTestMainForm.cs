using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandelbroatTest
{
    public partial class MandelbroatTestMainForm : Form
    {
        private double Y = 1, X = -2, Zoom = 1;

        public MandelbroatTestMainForm()
        {
            int Q = 0;
            InitializeComponent();
            draw();
        }

        private void TbXYZoom_TextChanged(object sender, EventArgs e)
        {
            draw();
        }

        private void draw()
        {
        }

        private void MandelbroatTestMainForm_Resize(object sender, EventArgs e)
        {
            draw();
        }
    }
}
