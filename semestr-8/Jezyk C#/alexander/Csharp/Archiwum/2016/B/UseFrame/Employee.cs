using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UseFrame
{
    public class Employee
    {
        public Bitmap Img { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Employee(Bitmap Img, string Name, string Phone)
        {
            this.Img = Img;
            this.Name = Name;
            this.Phone = Phone;
        }
    }
}
