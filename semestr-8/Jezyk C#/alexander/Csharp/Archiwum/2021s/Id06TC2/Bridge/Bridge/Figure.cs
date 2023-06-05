using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bridge
{
    public abstract class Figure
    {
        private delegate Figure maker(int[] par);
        private static Dictionary<string, maker> map = new Dictionary<string, maker>()
        {
            {"Circle", (par) => new Circle(par) },
            {"Triangle", (par) => new Triangle(par) },
            {"Rectangle", (par) => new Rectangle(par) },
        };
        private static int[] StrToArr(string par)
        {
            string[] sp = par.Split(" \t\r\n\v".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            int[] tb = new int[sp.Length];
            for (int i = 0; i < sp.Length; ++i) tb[i] = int.Parse(sp[i]);
            return tb;
        }
        public static string[] Kinds { get { return map.Keys.OrderBy((kind) => kind).ToArray(); } }
        public static Figure make(string kind, string par) { return map[kind](StrToArr(par)); }
        public abstract void Draw(Graphics g);
    }
    public class Circle:Figure
    {
        private int cx,cy,r;
        public Circle(int[] Tb)
        {
            if (Tb.Length != 3) throw new ArgumentException("Expected 3 parameters: cx,cy,r");
            cx = Tb[0];
            cy = Tb[1];
            r = Tb[2];
        }
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Red), cx - r, cy - r, 2 * r, 2 * r);
        }
        public override string ToString()
        {
            return string.Format("Circle {0},{1},{2}", cx, cy,r);
        }
    }
    public class Rectangle : Figure
    {
        private int ax, ay, bx, by;
        public Rectangle(int[] Tb)
        {
            if (Tb.Length != 4) throw new ArgumentException("Expected 3 parameters: ax, ay, bx, by");
            ax = Tb[0];
            ay = Tb[1];
            bx = Tb[2];
            by = Tb[3];
        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Blue), ax, ay, bx-ax, by-ay);
        }
        public override string ToString()
        {
            return string.Format("Rectangle {0},{1},{2},{3}", ax, ay, bx, by);
        }
    }
    public class Triangle : Figure
    {
        private int ax, ay, bx, by, cx, cy;
        public Triangle(int[] Tb)
        {
            if (Tb.Length != 6) throw new ArgumentException("Expected 3 parameters: ax, ay, bx, by, cx, cy");
            ax = Tb[0];
            ay = Tb[1];
            bx = Tb[2];
            by = Tb[3];
            cx = Tb[4];
            cy = Tb[5];
        }
        public override void Draw(Graphics g)
        {
            g.DrawLines(new Pen(Color.Brown), new Point[] { new Point(ax, ay), new Point(bx, by), new Point(cx, cy), new Point(ax, ay) });
        }
        public override string ToString()
        {
            return string.Format("Triangle {0},{1},{2},{3},{4},{5}", ax, ay, bx, by, cx, cy);
        }
    }
}
