using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arcanoid
{
    public class Palette
    {
        private static Brush background = Brushes.Gray;
        public static readonly float maxAcceleration = 2;
        public static readonly float maxSpeed = 70;
        public static readonly int Top = 12;
        public static readonly int Height = 5;
        public static readonly int HalfWidth = 30;
        public static readonly int Width = 2 * HalfWidth;
        private Board board;
        public float Position { get; private set; }
        public float Speed { get; private set; }
        private int MouseX;

        public Palette(Board board)
        {
            this.board = board;
            Position = MouseX = board.Width / 2;
            Speed = 0;
        }

        public void Draw()
        {
            float acceleration = Helper.MinMax(-maxAcceleration, MouseX - Position, maxAcceleration);
            Speed = Helper.MinMax(-maxSpeed, Speed * 0.90f + acceleration, maxSpeed);
            Position = Helper.MinMax(HalfWidth, Position + Speed, board.Width - HalfWidth);
            board.g.FillRectangle(background, Position - HalfWidth, board.Height - Top, Width, Height);
        }

        public void MouseMove(int mouseX)
        {
            MouseX = mouseX;
        }
    }
}
