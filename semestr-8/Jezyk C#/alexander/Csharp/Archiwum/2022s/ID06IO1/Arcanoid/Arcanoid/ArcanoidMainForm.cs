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
    public partial class ArcanoidMainForm : Form
    {
        private static readonly Brush boardBrush = Brushes.Black;
        private static readonly Brush paletteBrush = Brushes.Gray;
        private static readonly int paletteTop = 12;
        private static readonly int paletteHalfWidth = 40;
        private static readonly int paletteWidth = paletteHalfWidth*2;
        private static readonly int paletteHeight = 5;
        private static readonly int paletteMaxSpeed = 12;
        private static readonly float paletteMaxAcceleration = 1.8F;
        private Bitmap board = null;
        private Graphics g=null;
        private int boardX, boardY;
        private float paletteX = 0;
        private float mouseX = 0;
        private float mouseSpeed = 0;

        public ArcanoidMainForm()
        {
            InitializeComponent();
            PaBoard_Resize(null, null);
            paletteX = PbBoard.Width / 2;
            Timer.Enabled = true;
        }

        private void CleanBoard()
        {
            g.FillRectangle(boardBrush, 0, 0, boardX, boardY);
        }

        private void DrawPalette()
        {
            mouseSpeed += Math.Max(Math.Min(mouseX - paletteX, paletteMaxAcceleration), -paletteMaxAcceleration);
            paletteX = Math.Max(Math.Min(paletteX + mouseSpeed, boardX- paletteHalfWidth), paletteHalfWidth);
            if (paletteX <= paletteHalfWidth && mouseSpeed < 0) mouseSpeed = 0;
            if (paletteX >= boardX - paletteHalfWidth && mouseSpeed > 0) mouseSpeed = 0;
            g.FillRectangle(paletteBrush, paletteX - paletteHalfWidth, boardY - paletteTop, paletteWidth, paletteHeight);
        }

        private void DrawBoard()
        {
            CleanBoard();
            DrawPalette();
            PbBoard.Invalidate();
        }

        private void PaBoard_Resize(object sender, EventArgs e)
        {
            boardX = PbBoard.Width;
            boardY = PbBoard.Height;
            PbBoard.Image = board = new Bitmap(boardX, boardY);
            g = Graphics.FromImage(board);
        }

        private void PbBoard_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (board == null) return;
            DrawBoard();
        }
    }
}
