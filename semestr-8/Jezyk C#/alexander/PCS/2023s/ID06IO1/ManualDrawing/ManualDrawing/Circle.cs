using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ManualDrawing
{
    class ShapeCircle : Shape
    {
        private static Brush bg = Brushes.Aquamarine;
        private float x, y, r;
        public ShapeCircle(string text)
        {
            ParseLambdas(text, v => x = v, v => y = v, v => r = v);
        }
        public override void Draw(Graphics g, PointF shift, float scala)
        {
            g.FillEllipse
            (
                bg,
                Sc(x - r, shift.X, scala),
                Sc(y - r, shift.Y, scala),
                Sc(2 * r, shift.X, scala),
                Sc(2 * r, shift.Y, scala)
            );
        }
        public override float MinX() { return Math.Min(x - r, x + r); }
        public override float MaxX() { return Math.Max(x - r, x + r); }
        public override float MinY() { return Math.Min(y - r, y + r); }
        public override float MaxY() { return Math.Max(y - r, y + r); }
    }
}
