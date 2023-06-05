using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeTest
{
    delegate Figure FigureMaker(string parameters);
    class FigureList
    {
        public List<Figure> List { get; }
        public FigureList()
        {
            List = new List<Figure>();
        }
        public void Add(Figure fig) { List.Add(fig); }
        public void Remove(Figure fig) { List.Remove(fig); }
        public void Draw(Bridge br) { br.Draw(List); }
    }
    class Figure
    {
        private static Dictionary<string, FigureMaker> map = new Dictionary<string, FigureMaker>()
        {
            {"Circle",(string parameters) => new Circle(parameters)},
            {"Rectangle",(string parameters) => new Rectangle(parameters)},
            {"Triangle",(string parameters) => new Triangle(parameters)},
        };
        public static string[] keys()
        {
            return map.Keys.OrderBy(s => s).ToArray();
        }
        public static Figure make(string Kind, string parameters)
        {
            return map[Kind](parameters);
        }
        public static Point[] pointsFromString(string parameters)
        {
            List<Point> lst = new List<Point>();
            string[] plst = parameters.Split(" \t".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            foreach (string pt in plst)
            {
                string[] spt = pt.Split(",".ToCharArray());
                int x, y;
                if((spt.Length==2)&&(int.TryParse(spt[0],out x)) && (int.TryParse(spt[1], out y)))
                {
                    lst.Add(new Point(x, y));
                }
            }
            return lst.ToArray();
        }
        public static string makeName(string Kind,Point[] tb)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Kind).Append("(");
            bool first = true;
            foreach(var pt in tb)
            {
                if (first) first = false;
                else sb.Append(", ");
                sb.Append(pt.X).Append(", ").Append(pt.Y);
            }
            sb.Append(" )");
            return sb.ToString();
        }
    }
    class Circle : Figure
    {
        public Point TpLf { get; set; }
        public Point BtRt { get; set; }
        public Circle(string parameters)
        {
            Point[] tb = pointsFromString(parameters);
            if (tb.Length > 0) TpLf = tb[0];
            if (tb.Length > 1) BtRt = tb[1];
        }
        public Circle(Point TpLf, Point BtRt)
        {
            this.TpLf = TpLf;
            this.BtRt = BtRt;
        }
        public override string ToString()
        {
            return makeName("Circle",new Point[] { TpLf, BtRt });
        }
    }
    class Rectangle : Figure
    {
        public Point TpLf { get; set; }
        public Point BtRt { get; set; }
        public Rectangle(string parameters)
        {
            Point[] tb = pointsFromString(parameters);
            if (tb.Length > 0) TpLf = tb[0];
            if (tb.Length > 1) BtRt = tb[1];
        }
        public Rectangle(Point TpLf, Point BtRt)
        {
            this.TpLf = TpLf;
            this.BtRt = BtRt;
        }
        public override string ToString()
        {
            return makeName("Rectangle", new Point[] { TpLf, BtRt });
        }
    }
    class Triangle : Figure
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Triangle(string parameters)
        {
            Point[] tb = pointsFromString(parameters);
            if (tb.Length > 0) A = tb[0];
            if (tb.Length > 1) B = tb[1];
            if (tb.Length > 2) C = tb[2];
        }
        public Triangle(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public override string ToString()
        {
            return makeName("Triangle", new Point[] { A, B, C });
        }
    }
}
