using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arcanoid
{
    public class Carret
    {
        private int _MaxWidth, _HalfWidth;
        private Point _pos;
        private Brush brush;

        public Carret(int Width)
        {
            brush = new SolidBrush(Color.Green);
            _pos = new Point(0, 0);
            _MaxWidth = 0;
            _HalfWidth = Width >> 1;
        }

        public int MaxWidth
        {
            get { return _MaxWidth; }
            set
            {
                _MaxWidth = value;
                _pos.X = Math.Min(_pos.X, _MaxWidth - _HalfWidth);
            }
        }

        public Point pos
        {
            get { return _pos; }
        }

        public int HalfWidth
        {
            get { return _HalfWidth; }
        }

        public int YPos
        {
            get { return _pos.Y; }
            set
            {
                _pos.Y = value;
            }
        }

        public int XPos
        {
            get { return _pos.X; }
            set
            {
                _pos.X = Math.Max
                (
                    Math.Min(value, _MaxWidth - _HalfWidth), 
                    _HalfWidth
                );
            }
        }

        public void Draw(Graphics gr)
        {
            gr.FillRectangle(brush, _pos.X - _HalfWidth, _pos.Y, _HalfWidth << 1, 10);
        }
    }
}
