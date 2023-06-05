using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BridgeTest
{
    class FigureRectangle : Figure
    {
        private static readonly int PARAM_COUNT = 4;
        private int ax, ay, bx, by;
        public FigureRectangle(int[] tb)
        {
            if (tb.Length != PARAM_COUNT) throw new ArgumentException("Expected " + PARAM_COUNT + " paramters");
            ax = tb[0];
            ay = tb[1];
            bx = tb[2];
            by = tb[3];
        }
        public void Draw(Graphics gr)
        {
            gr.DrawRectangle(Pens.Blue, ax, ay, bx - ax, by - ay);
        }
        public string getKind() { return "Rectangle"; }
        public string getParameters()
        {
            return string.Format("{0}, {1}, {2}, {3}", ax, ay, bx, by);
        }
        public override string ToString()
        {
            return getKind() + '(' + getParameters() + ')';
        }
    }
}
