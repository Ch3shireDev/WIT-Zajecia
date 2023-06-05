using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BridgeTest
{
    class FigureTriangle : Figure
    {
        private static readonly int PARAM_COUNT = 6;
        private int ax, ay, bx, by, cx, cy;
        public FigureTriangle(int[] tb)
        {
            if (tb.Length != PARAM_COUNT) throw new ArgumentException("Expected " + PARAM_COUNT + " paramters");
            ax = tb[0];
            ay = tb[1];
            bx = tb[2];
            by = tb[3];
            cx = tb[4];
            cy = tb[5];
        }
        public void Draw(Graphics gr)
        {
            gr.DrawLines(Pens.Green, new Point[] { new Point(ax, ay), new Point(bx, by), new Point(cx, cy), new Point(ax, ay)});
        }
        public string getKind() { return "Triangle"; }
        public string getParameters()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}", ax, ay, bx, by, cx, cy);
        }
        public override string ToString()
        {
            return getKind() + '(' + getParameters() + ')';
        }
    }
}
