using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcanoid
{
    public partial class Arcanoid : Form
    {
        private Board board;
        public Arcanoid()
        {
            InitializeComponent();
            board = new Board(PbImage);
            PnImage_Resize(null, null);
            Timer.Enabled = true;
        }

        private void PnImage_Resize(object sender, EventArgs e)
        {
            board.Resize();
        }

        private void PbImage_MouseMove(object sender, MouseEventArgs e)
        {
            board.MouseMove(e.X);
        }

        private void PbImage_MouseDown(object sender, MouseEventArgs e)
        {
            board.Unstick();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            board.Draw();
        }
    }
}
