using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatern
{
    class ShapeTriangle : Shape
    {
        private static Brush bg = Brushes.Green;
        private float ax, ay, bx, by, cx, cy;
        public ShapeTriangle(string text)
        {
            ParseParams(text, v => ax = v, v => ay = v, v => bx = v, v => by = v, v => cx = v, v => cy = v);
        }
        public override void Draw(Graphics g)
        {
            g.FillPolygon(bg, new PointF[] { new PointF(ax,ay), new PointF(bx, by), new PointF(cx, cy) });
        }
        public override string ToXml()
        {
            return $"<rectangle ax=\"{ax}\" ay=\"{ay}\" bx=\"{bx}\" by=\"{by}\" />";
        }
        public override string ToString()
        {
            return $"Rectangle(ax:{ax},ay:{ay},bx:{bx},by:{by})";
        }
    }
}
