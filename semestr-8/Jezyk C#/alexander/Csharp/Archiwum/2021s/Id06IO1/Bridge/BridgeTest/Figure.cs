using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BridgeTest
{
    public abstract class Figure
    {
        private delegate Figure maker(string par);
        private static Dictionary<string, maker> map = new Dictionary<string, maker>()
        {
            {"Circle",(par)=>new Circle(par) },
            {"Rectangle",(par)=>new Rectangle(par) },
            {"Triangle",(par)=>new Triangle(par) },
        };
        public static readonly string[] Keys = map.Keys.OrderBy((kind) => kind).ToArray();
        public static Figure make(string kind,string par) { return map[kind](par); }
        public abstract void Draw(Graphics g);
        public static int[] Parse(string par,int len)
        {
            string[] args = par.Split(" \t\r\n\v;".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            if (len != args.Length) throw new ArgumentException(string.Format("Expected exactly {0} parameters", len));
            int[] ret = new int[len];
            for (int i = 0; i < len; ++i) ret[i] = int.Parse(args[i]);
            return ret;
        }
    }
    public class Circle : Figure
    {
        private int cx, cy, r;
        public Circle(int cx, int cy, int r)
        {
            this.cx = cx;
            this.cy = cy;
            this.r = r;
        }
        public Circle(string par)
        {
            int[] args = Parse(par,3);
            cx = args[0];
            cy = args[1];
            r = args[2];
        }
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Red, cx - r, cy - r, r << 1, r << 1);
        }
    }
    public class Rectangle : Figure
    {
        private int ax, ay, bx, by;
        public Rectangle(int ax, int ay, int bx, int by)
        {
            this.ax = ax;
            this.ay = ay;
            this.bx = bx;
            this.by = by;
        }
        public Rectangle(string par)
        {
            int[] args = Parse(par, 4);
            ax = args[0];
            ay = args[1];
            bx = args[2];
            by = args[3];
        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Blue, ax, ay, bx - ax, by - ay);
        }
    }
    public class Triangle : Figure
    {
        private int ax, ay, bx, by, cx, cy;
        public Triangle(int ax, int ay, int bx, int by, int cx, int cy)
        {
            this.ax = ax;
            this.ay = ay;
            this.bx = bx;
            this.by = by;
            this.cx = cx;
            this.cy = cy;
        }
        public Triangle(string par)
        {
            int[] args = Parse(par, 6);
            ax = args[0];
            ay = args[1];
            bx = args[2];
            by = args[3];
            cx = args[4];
            cy = args[5];
        }
        public override void Draw(Graphics g)
        {
            g.DrawLines(Pens.Olive, new Point[] { new Point(ax, ay), new Point(bx, by), new Point(cx, cy), new Point(ax, ay) });
        }
    }
}
