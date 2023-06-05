using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_2
{
    public class Point
    {
        private double x,y;
        public Point() { } // konstruktor domyślny -  bez parametrów
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static Point operator +(Point a,Point b)
        {
            return new Point(a.x + b.x, a.y + b.y);
        }
        public static Point operator /(Point p, double divider)
        {
            return new Point(p.x / divider, p.y / divider);
        }
        public double X
        {
            get { return x; }
            set { x=value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Z { get; set; }
        public double Length
        {
            get { return Math.Sqrt(x * x + y * y); }
            set 
            {
                double angle = Math.PI * Angle / 180;
                x = value * Math.Cos(angle);
                y = value * Math.Sin(angle);
            }
        }
        public double Angle
        {
            get { return 180*Math.Atan2(y, x)/Math.PI; }
            set
            {
                double length = Length, angle= Math.PI * value /180;
                x = length * Math.Cos(angle);
                y = length * Math.Sin(angle);
            }
        }
        public double VriteOnlyValue
        {
            set { x=y=value; }
        }
        /*
        private double getXY(int i)
        {
            if (i == 0) return this.x;
            else if (i == 1) return this.y;
            else throw new Exception("Bad index");
        }
        public static double this[int i]
        {
            get => getXY(i);
        }
        */
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p=new Point(); // (Stworzony automatycznie konstruktor (nic nie robiący) ponieważ brak jakiegokolwiek konstruktora) lub (napisany konstruktor domyślny)
            Console.WriteLine(string.Format("p.x={0}; p.y={1};",p.X,p.Y));
            Point q = new Point(3, 4);
            Console.WriteLine(string.Format("q.x={0}; q.y={1}; q.Length={2}; q.Angle={3};", q.X, q.Y, q.Length, q.Angle));
            Point m = (p + q) / 2;
            Console.WriteLine(string.Format("m.x={0}; m.y={1};", m.X, m.Y));
            m.Length = 50;
            Console.WriteLine(string.Format("m.x={0}; m.y={1};", m.X, m.Y));
            m.Angle = 45;
            Console.WriteLine(string.Format("m.x={0}; m.y={1};", m.X, m.Y));
            m.Angle = 90;
            Console.WriteLine(string.Format("m.x={0:F3}; m.y={1:F3};", m.X, m.Y));

            Console.ReadLine();
        }
    }
}
