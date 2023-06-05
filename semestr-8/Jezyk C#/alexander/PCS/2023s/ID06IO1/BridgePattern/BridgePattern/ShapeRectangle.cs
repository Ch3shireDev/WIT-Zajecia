using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class ShapeRectangle : Shape
    {
        private static Brush bg = Brushes.Blue;
        private float ax, ay, bx, by;
        public ShapeRectangle(string text)
        {
            ParseLambdas(text, v => ax = v, v => ay = v, v => bx = v, v => by = v);
        }
        public override void Draw(Graphics g)
        {
            g.FillRectangle
            (
                bg,
                ax,
                ay,
                bx-ax,
                by-ay
            );
        }
        public override string ToXml()
        {
            return $"<rectangle ax=\"{ax}\" ay=\"{ay}\" bx=\"{bx}\" by=\"{by}\" />";
        }
        public override string ToString()
        {
            return $"Rectangle(ax:{ax}, ay:{ay}, bx:{bx}, by:{by})";
        }
    }
}
