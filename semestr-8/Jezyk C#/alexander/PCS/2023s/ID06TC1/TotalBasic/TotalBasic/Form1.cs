using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalBasic
{
    public partial class Form1 : Form
    {
        private Animal animal1,animal2;
        public Form1()
        {
            InitializeComponent();
            Animal.y = 666;
            animal1 = new Animal(13, this_inform);
            animal1.x++;
            pod p = new pod() { x = 4, y = 3.3 };
            //Animal a = new Animal() { x=4, y=3.3 };
            animal1.call();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Point p = new Point() { X = 4, Y = 4 };
            Point p = new Point(3, 4);
            //Point p2 = new Point(5, 53.13,true);
            Point p2 = Point.Polar(5, 53.13);
            MessageBox.Show
            (
                "Kliknęto przycisk :" + (sender as Button).Text+Environment.NewLine+
                $"p.R={p.R}; p.A={p.A};"+ Environment.NewLine +
                $"p2.R={p2.R}; p2.A={p2.A};"
                //+@"\r\n"
            );
        }

        private void this_inform(int y, Animal animal)
        {
            //MessageBox.Show("A kuku");
        }

    }
    public class pod
    {
        public int x;
        public double y;
    }
    public class Animal
    {
        public delegate void Inform(int y, Animal animal);
        public static long y;
        public int x;
        public int _cokolwiek_sx;
        public int sx
        {
            get { return _cokolwiek_sx*3; }
            set { _cokolwiek_sx = value/3; }
        }
        public Inform inform;
        public Animal(int x, Inform inform)
        {
            this.x = x;
            this.inform = inform;
            //inform(x, this);
        }

        public static long GetY() { return y; }
        public static void SetY(long y) { Animal.y = y; }
        public void foo()
        {
            ++y;
            ++x;
            bar();
        }
        public static void bar()
        {
            ++y;
            //++x;
            //foo();
        }
        public void call()
        {
            inform(x, this);
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x,double y) { X = x;  Y = y; }
        //public Point(double r, double a,bool polar) { R = r; A = a; }

        public static Point Polar(double r, double a)
        {
            Point p = new Point(0,r);
            p.A = a;
            return p;
        }

        public double R
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
            set
            {
                double a = A * Math.PI / 180;
                X = value * Math.Cos(a);
                Y = value * Math.Sin(a);
            }
        }
        public double A
        {
            get
            {
                return 180*Math.Atan2(Y,X)/Math.PI;
            }
            set
            {
                double r = R;
                double a = A * Math.PI / 180;
                X = r * Math.Cos(a);
                Y = r * Math.Sin(a);
            }
        }
    }
}
