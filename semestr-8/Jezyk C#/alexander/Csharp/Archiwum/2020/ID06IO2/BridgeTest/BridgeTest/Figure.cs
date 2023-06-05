using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BridgeTest
{
    public interface Figure
    {
        void Draw(Graphics gr);
    }
    class FigCircle : Figure
    {
        private int x, y, r;
        public FigCircle(int[] tb)
        {
            if (tb.Length != 3) throw new InvalidOperationException();
            x = tb[0];
            y = tb[1];
            r = tb[2];
        }
        public void Draw(Graphics gr)
        {
            gr.DrawEllipse(Pens.Red, x - r, y - r, x + r, y + r);
        }
        public override string ToString()
        {
            return string.Format("Circle {0},{1},{2}", x, y, r);
        }
    }
    class FigRectangle : Figure
    {
        private int ax, ay, bx, by;
        public FigRectangle(int[] tb)
        {
            if (tb.Length != 4) throw new InvalidOperationException();
            ax = tb[0];
            ay = tb[1];
            bx = tb[2];
            by = tb[3];
        }
        public void Draw(Graphics gr)
        {
            gr.DrawRectangle(Pens.Blue, ax, ay, bx - ax, by - ay);
        }
        public override string ToString()
        {
            return string.Format("Rectangle {0},{1},{2},{3}", ax, ay, bx, by);
        }
    }
    class FigTriangle : Figure
    {
        private int ax, ay, bx, by, cx, cy;
        public FigTriangle(int[] tb)
        {
            if (tb.Length != 6) throw new InvalidOperationException();
            ax = tb[0];
            ay = tb[1];
            bx = tb[2];
            by = tb[3];
            cx = tb[4];
            cy = tb[5];
        }
        public void Draw(Graphics gr)
        {
            gr.DrawLines(Pens.Green, new Point[] { new Point(ax, ay), new Point(bx, by), new Point(cx, cy), new Point(ax, ay) });
        }
        public override string ToString()
        {
            return string.Format("Triangle {0},{1},{2},{3},{4},{5}", ax, ay, bx, by, cx, cy);
        }
    }
    delegate Figure FigureMaker(int[] parameters);
    class FigureFabric
    {
        private static Dictionary<string, FigureMaker> map = new Dictionary<string, FigureMaker>()
        {
            {"Circle", (parameters) => new FigCircle(parameters)},
            {"Rectangle", (parameters) => new FigRectangle(parameters)},
            {"Triangle", (parameters) => new FigTriangle(parameters)},
        };
        public static Figure make(string kind, string parmeters)
        {
            string[] values = parmeters.Split(" \t,".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            int[] tb = new int[values.Length];
            for (int i = 0; i < values.Length; ++i) tb[i] = int.Parse(values[i]);
            return map[kind](tb);
        }
        public static string[] keys
        {
            get
            {
                return map.Keys.OrderBy((s) => s).ToArray();
            }
        }
    }
}
