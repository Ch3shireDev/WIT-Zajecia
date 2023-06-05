using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BridgeTest
{
    class FigureCircle : Figure
    {
        private static readonly int PARAM_COUNT=3;
        private int x, y, r;
        public FigureCircle(int[] tb)
        {
            if (tb.Length != PARAM_COUNT) throw new ArgumentException("Expected " + PARAM_COUNT + " paramters");
            x = tb[0];
            y = tb[1];
            r = tb[2];
        }
        public void Draw(Graphics gr)
        {
            gr.DrawEllipse(Pens.Red, x - r, y - r, r << 1, r << 1); // r << 1 <=> r*2;
        }
        public string getKind() { return "Circle"; }
        public string getParameters()
        {
            return string.Format("{0}, {1}, {2}", x, y, r);
        }
        public override string ToString()
        {
            return getKind() + '(' + getParameters() + ')';
        }
    }
}
