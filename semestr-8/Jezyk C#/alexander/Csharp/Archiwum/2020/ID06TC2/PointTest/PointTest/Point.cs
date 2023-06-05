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
        private string name;

        public double x, y;
        public Point(string name="pkt") { this.name = name; x = y = 0; }
        public Point(string name,double x, double y) { this.name = name; this.x = x; this.y = y; }
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value) MessageBox.Show(string.Format("{0} changed to {1}", name, value));
                name = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}: ( {1:F2} ; {2:F2} )", name, x, y);
        }
    }
}
