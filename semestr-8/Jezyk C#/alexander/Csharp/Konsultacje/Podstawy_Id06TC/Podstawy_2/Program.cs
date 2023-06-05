using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_2
{
    public class Point
    {
        private double y, x;
        public Point() { x = y = 0; }
        public Point(double y, double x) { this.x = x; this.y = y; }

        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public double Xreadonly { get { return x; } }
        public double Xwriteonly { set { y = value; } }
        public double Z { get; set; }

        public double Angle
        {
            get { return 180*Math.Atan2(y, x)/Math.PI; }
            set
            {
                double angle = Math.PI * value / 180, length = Length;
                y = length * Math.Sin(angle);
                x = length * Math.Cos(angle);
            }
        }
        public double Length
        {
            get { return Math.Sqrt(y * y + x * x); }
            set
            {
                double angle = Math.PI * Angle / 180, length = value;
                y = length * Math.Sin(angle);
                x = length * Math.Cos(angle);
            }
        }

        public static Point operator + (Point a, Point b)
        {
            return new Point(a.y + b.y, a.x + b.x);
        }
        public static Point operator /(Point p, double div) { return new Point(p.y / div, p.x / div); }
        public static Point operator *(Point p, double mul) { return new Point(p.y * mul, p.x * mul); }
        public static Point operator *(double mul, Point p) { return new Point(p.y * mul, p.x * mul); }
    }

    public interface Sub
    {
        double sub(double a, double b);
    }
    public interface Add
    {
        double add(double a, double b);
    }

    public abstract class XOperation : Sub, Add
    {
        public double sub(double a, double b) { return a - b; }
        public abstract double add(double a, double b);
        public virtual double mul(double a, double b) { return a / b; }
    }
    public class XXOperation : XOperation
    {
        public override double add(double a, double b) { return a + b; }
        public override double mul(double a, double b) { return a * b; }
    }

    public class Operation:Sub,Add
    {
        public double sub(double a, double b) { return a-b; }
        public double add(double a, double b) { return a+b; }
    }

    public interface SubX
    {
        double execute(double a, double b);
    }
    public interface AddX
    {
        double execute(double a, double b);
    }

    //public class OperationX:SubX,AddX
    //{
        //public double SubX.execute(double a, double b) { return a - b; } // przejdzie w nowym VS
        //public double AddX.execute(double a, double b) { return a + b; } // przejdzie w nowym VS
    //}

    public class Methods
    {
        public static double add(double a=0,double b=0,double c=0, double d=0) { return a + b + c + d; } // Parametry domyślne
        public static void sub(ref double value, double sbb) { value -= sbb; }
        public static void calc(out double value) { value = Math.PI; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point q = new Point(3, 4);
            Point p = new Point(); // Tworzony automatycznie jeżeli brak konstruktorów, lub zdefiniowany
            Point m = 0.5 * (p + q);
            Console.WriteLine("x={0}; y={1}; Angle={2}; Lengh={3};", q.X, q.Y, q.Angle, q.Length);
            Console.WriteLine("x={0}; y={1}; Angle={2}; Lengh={3};", m.X, m.Y, m.Angle, m.Length);
            m.Length *= 2;
            Console.WriteLine("x={0}; y={1}; Angle={2}; Lengh={3};", m.X, m.Y, m.Angle, m.Length);
            m.Length *= 2;
            Console.WriteLine("x={0}; y={1}; Angle={2}; Lengh={3};", m.X, m.Y, m.Angle, m.Length);

            p.X = 12;
            p.Y = 1;

            //XOperation xop = new XOperation(); // klasa abstrakcyjan - nie ma obiektów
            XOperation xop = new XXOperation();
            XXOperation xxop = new XXOperation();

            Operation op = new Operation();
            Sub sub = op;
            Add add = op;
            Console.WriteLine("sub=>{0}; add=>{1}", op.sub(1, 2), op.add(1, 2));
            Console.WriteLine("sub=>{0}; add=>{1}", sub.sub(1, 2), add.add(1, 2));
            //Console.WriteLine("sub=>{0}; add=>{1}", add.sub(1, 2), sub.add(1, 2)); // tylko to co mamy w interfesie

            Console.WriteLine("add1 = {0}", Methods.add(1, 2, 3, 4));
            Console.WriteLine("add1 = {0}", Methods.add(1, 2, 3));
            Console.WriteLine("add1 = {0}", Methods.add(1, 2));
            Console.WriteLine("add1 = {0}", Methods.add(1));
            Console.WriteLine("add1 = {0}", Methods.add());

            double value=100;
            Methods.sub(ref value, 10);
            double pi;
            Methods.calc(out pi);

            Console.ReadLine();
        }
    }
}
