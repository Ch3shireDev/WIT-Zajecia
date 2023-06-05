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
        protected int[] args;
        public Figure(string param,int length)
        {
            string[] data = param.Split(" \t\r\n\v".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            if (length != data.Length) throw new ArgumentException(string.Format("Expected {0} parameters", length));
            args = new int[length];
            for (int i = 0; i < length; ++i) args[i] = int.Parse(data[i]);
        }
        public abstract void Draw(Graphics g);
    }
    public abstract class FigureFactory
    {
        private delegate Figure maker(string param);
        private static Dictionary<string, maker> map = new Dictionary<string, maker>()
        {
            {"Circle",(param)=>new Circle(param)},
            {"Rectangle",(param)=>new Rectangle(param)},
            {"Triangle",(param)=>new Triangle(param)},
        };
        public static readonly string[] keys = map.Keys.OrderBy((kind) => kind).ToArray();
        public static Figure make(string kind, string param) { return map[kind](param); }
    }
    public class Circle:Figure
    {
        public Circle(string param) : base(param,3) { }
        int cx { get { return args[0]; } }
        int cy { get { return args[1]; } }
        int r { get { return args[2]; } }
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Blue, cx - r, cy - r, r << 1, r << 1);
        }
        public override string ToString() { return string.Format("Circle({0},{1},{2})",cx,cy,r); }
    }
    public class Rectangle : Figure
    {
        public Rectangle(string param) : base(param, 4) { }
        int ax { get { return args[0]; } }
        int ay { get { return args[1]; } }
        int bx { get { return args[2]; } }
        int by { get { return args[3]; } }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Red, ax, ay, bx - ax, by - ay);
        }
        public override string ToString() { return string.Format("Rectangle({0},{1},{2},{3})", ax, ay, bx, by); }
    }
    public class Triangle : Figure
    {
        public Triangle(string param) : base(param, 6) { }
        int ax { get { return args[0]; } }
        int ay { get { return args[1]; } }
        int bx { get { return args[2]; } }
        int by { get { return args[3]; } }
        int cx { get { return args[4]; } }
        int cy { get { return args[5]; } }
        public override void Draw(Graphics g)
        {
            g.DrawLines(Pens.Olive,new Point[] { new Point(ax, ay), new Point(bx, by), new Point(cx, cy), new Point(ax, ay) });
        }
        public override string ToString() { return string.Format("Triangle({0},{1},{2},{3},{4},{5})", ax, ay, bx, by, cx, cy); }
    }
}
