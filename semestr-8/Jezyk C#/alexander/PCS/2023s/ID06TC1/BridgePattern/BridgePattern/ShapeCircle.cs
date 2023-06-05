using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class ShapeCircle : ShapeBase
    {
        private int cx,cy,r;
        public ShapeCircle(string parameters)
        {
            Parse(parameters, (v) => cx = v, (v) => cy = v, (v) => r = v);
        }
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Red, cx - r, cy - r, 2 * r, 2 * r);
        }

        public override string ToXml()
        {
            return $"<circle cx=\"{cx}\" cy=\"{cy}\" r=\"{r}\" />";
        }
        public override string ToString()
        {
            return $"Circle(cx:{cx},cy:{cy},r:{r})";
        }
    }
}
