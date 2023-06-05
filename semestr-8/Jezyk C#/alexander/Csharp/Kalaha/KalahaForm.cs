using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kh
{
    public partial class Kalaha : Form
    {
        private Button[] Boxes;
        private static readonly int SideCount = 7;
        private static readonly int BasePosition = SideCount - 1;
        private static readonly int LastBoxPosition = BasePosition - 1;
        public Kalaha()
        {
            InitializeComponent();
            Boxes = new Button[]
            {
                BtnU1,BtnU2,BtnU3,BtnU4,BtnU5,BtnU6,  BtnU0,
                BtnD1,BtnD2,BtnD3,BtnD4,BtnD5,BtnD6,  BtnD0,
            };
        }

        private void BoxClick(object sender, EventArgs e)
        {
            int box = Array.IndexOf(Boxes, sender);
            Text = box.ToString();
        }
    }
}
