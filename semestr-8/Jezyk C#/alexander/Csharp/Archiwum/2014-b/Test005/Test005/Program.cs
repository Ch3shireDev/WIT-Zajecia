using System;
using System.Text;

namespace Test005
{
    class Point
    {
        public double X, Y;
        static double toRad(double value) { return value * Math.PI / 180; }
        static double toGrad(double value) { return value * 180 / Math.PI; }
        public Point(double x, double y) { X = x; Y = y; }
        public Point() { X = Y = 0; }
        public double Distance(double x, double y) { x -= X; y -= Y; return Math.Sqrt(x * x + y * y); }
        public double Distance(Point p) { return Distance(p.X, p.Y); }
        public double Distance() { return Distance(0, 0); }
        public double Angle() { return toGrad(Math.Atan2(Y, X)); }
        public void Distance(double new_distance) 
        {
            double old_angle = toRad(Angle());
            X = new_distance * Math.Cos(old_angle);
            Y = new_distance * Math.Sin(old_angle);
        }
        public void Angle(double new_angle)
        {
            new_angle = toRad(new_angle);
            double old_distance = Distance();
            X = old_distance * Math.Cos(new_angle);
            Y = old_distance * Math.Sin(new_angle);
        }
        public double distance { get { return Distance(); } set { Distance(value); } }
        public double angle { get { return Angle(); } set { Angle(value); } }
    }
    class Robot
    {
        public Point gps { get; set; }
        public Point target { get; set; }
        public double speed { get; set; }
        //private uint speed;
        public Robot(Point start) { gps = start; speed = 0; target = gps; }
        //private Point tar;
        //public Point target { get { return tar } set { tar = value; } } 
        public void Step()
        {
            if (gps.Distance(target) <= speed) gps = target;
            else
            {
                Point p = new Point(gps.X - target.X, gps.Y - target.Y);
                p.distance -= speed;
                p.X += target.X;
                p.Y += target.Y;
                gps = p;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point start = new Point(60, 80);
            Robot R = new Robot(start);
            R.target = new Point(80, 60);
            R.speed = 5;
            Console.WriteLine("Distance {0}", R.gps.Distance(R.target));
            Console.WriteLine("({0},{1})", R.gps.X, R.gps.Y);
            while ((R.gps.X != R.target.X) || (R.gps.Y != R.target.Y))
            {
                R.Step();
                Console.WriteLine("({0},{1})", R.gps.X, R.gps.Y);
            }
            Console.ReadKey();
        }
    }
}
