using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace BridgeTest
{
    delegate Figure FigureMaker(string param);
    abstract class Figure
    {
        private static Dictionary<string, FigureMaker> map = new Dictionary<string, FigureMaker>() 
        {
            {"Prostokąt",(string param)=>new FigRectangle(param)},
            {"Trójkąt",(string param)=>new FigTriangle(param)},
            {"Okrąg",(string param)=>new FigCircle(param)},
        };
        public static string[] keys()
        {
            return map.Keys.OrderBy(name => name).ToArray();
        }
        public static Figure make(string kind, string param)
        {
            return map[kind](param);
        }
        public abstract void Draw(Graphics gr);
        public static string PointsToStr(string Prefix,Point[] pts)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Prefix).Append("(");
            foreach(Point pt in pts)
            {
                sb.Append(' ').Append(pt.X).Append(';').Append(pt.Y);
            }
            sb.Append(" )");
            return sb.ToString();
        }
        public static Point[] StrToPoints(string param)
        {
            string[] tb = param.Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            List<Point> pt = new List<Point>();
            foreach (string row in tb)
            {
                string[] it = row.Split(";".ToCharArray());
                int x, y;
                if((it.Length==2)&&(int.TryParse(it[0],out x)) && (int.TryParse(it[1], out y)))
                {
                    pt.Add(new Point(x, y));
                }
            }
            return pt.ToArray();
        }
    }
    class FigRectangle : Figure
    {
        public Point TpLf { get; private set; }
        public Point BtRt { get; private set; }
        public FigRectangle(Point TpLf, Point BtRt)
        {
            this.TpLf = TpLf;
            this.BtRt = BtRt;
        }
        public FigRectangle(string param)
        {
            Point[] pts = StrToPoints(param);
            if (pts.Length > 0) TpLf = pts[0];
            if (pts.Length > 1) BtRt = pts[1];
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(new Pen(Color.Blue), TpLf.X, TpLf.Y, BtRt.X - TpLf.X, BtRt.Y - TpLf.Y);
        }
        public override string ToString()
        {
            return PointsToStr("Prostokąt", new Point[] { TpLf, BtRt });
        }
    }
    class FigTriangle : Figure
    {
        public Point A { get; private set; }
        public Point B { get; private set; }
        public Point C { get; private set; }
        public FigTriangle(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public FigTriangle(string param)
        {
            Point[] pts = StrToPoints(param);
            if (pts.Length > 0) A = pts[0];
            if (pts.Length > 1) B = pts[1];
            if (pts.Length > 2) C = pts[2];
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawLines(new Pen(Color.Green), new Point[] { A, B, C, A });
        }
        public override string ToString()
        {
            return PointsToStr("Trójkąt", new Point[] { A, B, C });
        }
    }
    class FigCircle : Figure
    {
        public Point TpLf { get; private set; }
        public Point BtRt { get; private set; }
        public FigCircle(Point TpLf, Point BtRt)
        {
            this.TpLf = TpLf;
            this.BtRt = BtRt;
        }
        public FigCircle(string param)
        {
            Point[] pts = StrToPoints(param);
            if (pts.Length > 0) TpLf = pts[0];
            if (pts.Length > 1) BtRt = pts[1];
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(new Pen(Color.Red), TpLf.X, TpLf.Y, BtRt.X - TpLf.X, BtRt.Y - TpLf.Y);
        }
        public override string ToString()
        {
            return PointsToStr("Okrąg", new Point[] { TpLf, BtRt });
        }
    }
}
