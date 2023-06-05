using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointTest
{
    class Point
    {
        public double x;
        public double y { get;  set; }
        public Point(double x,double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point SetX(double x) { this.x = x; return this; }
        public Point SetY(double y) { this.y = y; return this; }

        public Point() { x = y = 0; }
        /*
        public double X
        {
            get { return x; }
            set
            {
                if (x != value) MessageBox.Show("Changes " + x + " to " + value);
                x = value;
            }
        }
        */
        public override string ToString()
        {
            return string.Format("({0:F2},{1:F2})", x, y);
        }
    }
}
