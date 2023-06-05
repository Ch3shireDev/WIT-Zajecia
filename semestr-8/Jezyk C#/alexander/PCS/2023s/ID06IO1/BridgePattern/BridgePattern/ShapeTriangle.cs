using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class ShapeTriangle : Shape
    {
        private static Brush bg = Brushes.Green;
        private float ax, ay, bx, by, cx, cy;
        public ShapeTriangle(string text)
        {
            ParseLambdas(text, v => ax = v, v => ay = v, v => bx = v, v => by = v, v => cx = v, v => cy = v);
        }
        public override void Draw(Graphics g)
        {
            g.FillPolygon
            (
                bg,
                new PointF[]
                {
                    new PointF(ax,ay),
                    new PointF(bx,by),
                    new PointF(cx,cy),
                }
            );
        }
        public override string ToXml()
        {
            return $"<triangle ax=\"{ax}\" ay=\"{ay}\" bx=\"{bx}\" by=\"{by}\" cx=\"{cx}\" cy=\"{cy}\" />";
        }
        public override string ToString()
        {
            return $"Triangle(ax:{ax}, ay:{ay}, bx:{bx}, by:{by}, cx:{cx}, cy:{cy})";
        }
    }
}