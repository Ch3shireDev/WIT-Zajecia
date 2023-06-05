using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatern
{
    public class ShapeCircle :Shape
    {
        private static Brush bg = Brushes.Red;
        private float x, y, r;
        public ShapeCircle(string text)
        {
            ParseParams(text, v => x = v, v => y = v, v => r = v);
        }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(bg, x - r, y - r, 2 * r, 2 * r);
        }
        public override string ToXml()
        {
            return $"<circle x=\"{x}\" y=\"{y}\" r=\"{r}\" />";
        }
        public override string ToString()
        {
            return $"Circle(x:{x},y:{y},r:{r})";
        }
    }
}
