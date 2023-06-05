using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualDrawing
{
    class Circle:Shape
    {
        private static Brush bg = Brushes.BlanchedAlmond;
        private float x, y, r;
        public Circle(string text)
        {
            ParseParams(text,v => x = v, v => y = v, v => r = v);
        }
        public override void Draw(Graphics g,PointF shift,float scale)
        {
            g.FillEllipse
            (
                bg, 
                Scale(x - r, shift.X, scale),
                Scale(y - r, shift.Y, scale),
                Scale(2 * r, shift.X, scale),
                Scale(2 * r, shift.Y, scale)
            );
        }
        public override float minX() { return Math.Min(x - r, x + r); }
        public override float maxX() { return Math.Max(x - r, x + r); }
        public override float minY() { return Math.Min(y - r, y + r); }
        public override float maxY() { return Math.Max(y - r, y + r); }
    }
}
