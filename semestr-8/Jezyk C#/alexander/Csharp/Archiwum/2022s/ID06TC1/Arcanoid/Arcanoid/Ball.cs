using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arcanoid
{
    public class Ball
    {
        private static Brush background = Brushes.Red;
        private static int Radius = 5;
        private static int Diameter = 2 * Radius;
        private Board board;
        private bool Sticked;
        public float pX { get; private set; }
        public float pY { get; private set; }
        public float vX { get; private set; }
        public float vY { get; private set; }
        
        public Ball(Board board)
        {
            this.board = board;
            Sticked = true;
        }

        public void Draw()
        {
            if (Sticked)
            {
                pX = board.palette.Position;
                pY = board.Height - Palette.Top - Radius;
            }
            else
            {
                pX += vX;
                pY += vY;
            }
            board.g.FillEllipse(background, pX-Radius, pY-Radius, Diameter, Diameter);
        }

        public void Unstick()
        {
            if(Sticked)
            {
                pX = board.palette.Position;
                pY = board.Height - Palette.Top - Radius;
                vY = -12;
                vX = board.palette.Speed / 5.0f;
                Sticked = false;
            }
        }
    }
}
