using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class ShapeTriangle : ShapeBase
    {
        private int ax, ay, bx, by, cx, cy;
        public ShapeTriangle(string parameters)
        {
            Parse(parameters, (v) => ax = v, (v) => ay = v, (v) => bx = v, (v) => by = v, (v) => cx = v, (v) => cy = v);
        }
        public override void Draw(Graphics g)
        {
            g.DrawPolygon
            (
                Pens.Green,
                new Point[] { new Point(ax,ay), new Point(bx, by), new Point(cx, cy) }
            );
        }

        public override string ToXml()
        {
            return $"<triangle ax=\"{ax}\" ay=\"{ay}\" bx=\"{bx}\" by=\"{by}\" cx=\"{cx}\" cy=\"{cy}\" />";
        }
        public override string ToString()
        {
            return $"Triangle(cx:{ax},cy:{ay},bx:{bx},by:{by},cx:{cx},cy:{cy})";
        }
    }
}
