using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeTest
{
    public abstract class Figure
    {
        private delegate Figure maker(string param);
        private static Dictionary<string, maker> map = new Dictionary<string, maker>()
        {
            {"Circle",(param) => new Circle(param) },
            {"Rectangle",(param) => new Rectangle(param) },
            {"Triangle",(param) => new Triangle(param) },
        };
        public static readonly string[] Kinds = map.Keys.OrderBy((kind) => kind).ToArray();
        protected int[] args;
        public Figure(string param,int size)
        {
            string[] data = param.Split(" ;\t\r\n\v".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            if (size != data.Length) throw new ArgumentException(string.Format("Expected {0} values", size));
            args = new int[size];
            for (int i = 0; i < size; ++i) args[i] = int.Parse(data[i]);
        }
        public static Figure make(string kind, string param) { return map[kind](param); }
        public abstract void Draw(Graphics g);
    }
    public class Circle:Figure
    {
        public Circle(string param) : base(param,3) {}
        public int cx { get { return args[0]; } }
        public int cy { get { return args[1]; } }
        public int r { get { return args[2]; } }
        public override void Draw(Graphics g) { g.DrawEllipse(Pens.Red, cx - r, cy - r, r << 1, r << 1); }
        public override string ToString() { return string.Format($"Circle({cx},{cy},{r})"); }
    }
    public class Rectangle : Figure
    {
        public Rectangle(string param) : base(param, 4) { }
        public int ax { get { return args[0]; } }
        public int ay { get { return args[1]; } }
        public int bx { get { return args[2]; } }
        public int by { get { return args[3]; } }
        public override void Draw(Graphics g) { g.DrawRectangle(Pens.Blue, ax, ay, bx - ax, by - ay); }
        public override string ToString() { return string.Format($"Rectangle({ax},{ay},{bx},{by})"); }
    }
    public class Triangle : Figure
    {
        public Triangle(string param) : base(param, 6) { }
        public int ax { get { return args[0]; } }
        public int ay { get { return args[1]; } }
        public int bx { get { return args[2]; } }
        public int by { get { return args[3]; } }
        public int cx { get { return args[4]; } }
        public int cy { get { return args[5]; } }
        public override void Draw(Graphics g)
        {
            g.DrawLines(Pens.Olive, new Point[] { new Point(ax, ay), new Point(bx, by), new Point(cx, cy), new Point(ax, ay) });
        }
        public override string ToString() { return string.Format($"Triangle({ax},{ay},{bx},{by},{cx},{cy})"); }
    }
}
