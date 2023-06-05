using System.Drawing;

namespace Arcanoid
{
    public class Palette
    {
        private static readonly Brush background = Brushes.Gray;
        public static readonly int Top = 15;
        private static readonly int HalfWidth = 30;
        private static readonly int Width = 2 * HalfWidth;
        private static readonly int Height = 10;
        private static readonly float MaxSpeed = 80;
        private static readonly float MaxAcceleration = 10;
        private Board board;
        private int MouseX;
        public float Position { get; private set; }
        public float Speed { get; private set; }

        public Palette(Board board)
        {
            this.board = board;
        }

        public void Draw()
        {
            float acceleration = Helper.minmax(-MaxAcceleration, MouseX - Position, MaxAcceleration);
            Speed = Helper.minmax(-MaxSpeed, 0.7F * Speed + acceleration, MaxSpeed);
            Position = Helper.minmax(HalfWidth, Position + Speed, board.Width - HalfWidth);
            board.g.FillRectangle(background, Position - HalfWidth, board.Height - Top, Width, Height);
        }

        public void Resize()
        {
            Position = board.Width / 2;
        }

        public void Mouse(int MouseX)
        {
            this.MouseX = MouseX;
        }
    }
}