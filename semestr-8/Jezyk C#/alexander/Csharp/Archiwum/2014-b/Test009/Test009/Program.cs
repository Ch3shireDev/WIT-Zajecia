using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test009
{
    class Point
    {
        public double x;
        public double y;
        public Point() { x = y = 0; }
        public Point(double x, double y) { this.x = x; this.y = y; }
        public static double grad(double v) { return 180 * v / Math.PI; }
        public static double rad(double v) { return Math.PI * v / 180; }
        public double angle
        { 
            get
            {
                return grad(Math.Atan2(y, x));
            }
            set
            {
                double len = length;
                y = len * Math.Sin(rad(value));
                x = len * Math.Cos(rad(value));
            }
        }
        public double length
        {
            get
            {
                return Math.Sqrt(x * x + y * y);
            }
            set
            {
                double ang = rad(angle);
                y = value * Math.Sin(ang);
                x = value * Math.Cos(ang);
            }
        }
        public static Point operator+(Point a,Point b)
        {
            return new Point(a.x + b.x, a.y + b.y);
        }
        public static Point operator -(Point p)
        {
            return new Point(-p.x, -p.y);
        }
        public static Point operator -(Point a, Point b)
        {
            return a+(-b);
            //return new Point(a.x - b.x, a.y - b.y);
        }
        public static double operator *(Point a,Point b)
        {
            return a.x * b.x + a.y * b.y;
        }
        public static Point operator *(Point p, double m)
        {
            return new Point(p.x * m, p.y * m);
        }
        public static Point operator *(double m, Point p)
        {
            return p * m;
        }
        public override string ToString()
        {
            return string.Format("({0};{1})", x, y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(3, 4);
            Console.WriteLine("{0} {1:0.00}:{2:0.00}", p, p.angle, p.length);
            p.angle = 0;
            Console.WriteLine("{0} {1:0.00}:{2:0.00}", p, p.angle, p.length);
            p.angle = -360;
            Console.WriteLine("{0} {1:0.00}:{2:0.00}", p, p.angle, p.length);
            Console.ReadKey();
        }
    }
}
