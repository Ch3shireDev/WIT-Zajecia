using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcanoid
{
    public class Ball
    {
        private static readonly Brush background = Brushes.Red;
        private static readonly int Radius = 6;
        private static readonly int Diameter = 2 * Radius;
        private Board board;
        private bool Sticked = true;
        public float bX { get; private set; }
        public float bY { get; private set; }
        public float vX { get; private set; }
        public float vY { get; private set; }

        public Ball(Board board)
        {
            this.board = board;
        }

        public void Draw()
        {
            if (Sticked)
            {
                bX = board.palette.Position;
                bY = board.Height - Palette.Top - Radius;
            }
            else
            {
                bX += vX;
                bY += vY;
            }
            board.g.FillEllipse(background, bX - Radius, bY - Radius, Diameter, Diameter);
        }

        public void Unstick()
        {
            if(Sticked)
            {
                vY = -12;
                vX = board.palette.Speed / 15;
                Sticked = false;
            }
        }
    }
}
