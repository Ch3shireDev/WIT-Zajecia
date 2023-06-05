using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BridgeTest
{
    delegate Figure FigureMaker(int[] tb);
    public interface Figure
    {
        void Draw(Graphics g);
    }
    public class FigCircle : Figure
    {
        private int x,y,r;
        public FigCircle(int[] tb)
        {
            if (tb.Length != 3) throw new InvalidOperationException("Expect 3 parameters");
            x = tb[0];
            y = tb[1];
            r = tb[2];
        }
        public void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Green, x - r, y - r, r << 1, r << 1);
        }
        public override string ToString()
        {
            return string.Format("Circle({0},{1},{2})", x, y, r);
        }
    }
    public class FigRectangle : Figure
    {
        private int ax, ay, bx, by;
        public FigRectangle(int[] tb)
        {
            if (tb.Length != 4) throw new InvalidOperationException("Expect 4 parameters");
            ax = tb[0];
            ay = tb[1];
            bx = tb[2];
            by = tb[3];
        }
        public void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Blue, ax, ay, bx - ax, by - ay);
        }
        public override string ToString()
        {
            return string.Format("Rectangle({0},{1},{2},{3})", ax, ay, bx, by);
        }
    }
    public class FigTriangle : Figure
    {
        private int ax, ay, bx, by, cx, cy;
        public FigTriangle(int[] tb)
        {
            if (tb.Length != 6) throw new InvalidOperationException("Expect 6 parameters");
            ax = tb[0];
            ay = tb[1];
            bx = tb[2];
            by = tb[3];
            cx = tb[4];
            cy = tb[5];
        }
        public void Draw(Graphics g)
        {
            g.DrawLines(Pens.Red, new Point[] { new Point(ax, ay), new Point(bx, by), new Point(cx, cy), new Point(ax, ay) });
        }
        public override string ToString()
        {
            return string.Format("Triangle({0},{1},{2},{3},{4}.{5})", ax, ay, bx, by, cx, cy);
        }
    }
    public class FigureFabric
    {
        private static Dictionary<string, FigureMaker> map = new Dictionary<string, FigureMaker>()
        {
            {"Circle", (tb) => new FigCircle(tb) },
            {"Rectangle", (tb) => new FigRectangle(tb) },
            {"Triangle", (tb) => new FigTriangle(tb) },
        };
        public static List<string> Keys
        {
            get { return map.Keys.OrderBy((s) => s).ToList(); }
        }
        public static Figure Make(string kind,string parameters)
        {
            string[] items = parameters.Split(" \t,".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            int[] tb = new int[items.Length];
            for (int i = 0; i < tb.Length; ++i) tb[i] = int.Parse(items[i]);
            return map[kind](tb);
        }
    }
}
