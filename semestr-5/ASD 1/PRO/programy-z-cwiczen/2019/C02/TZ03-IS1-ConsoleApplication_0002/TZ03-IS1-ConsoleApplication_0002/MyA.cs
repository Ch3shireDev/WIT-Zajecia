using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyANamespace
{
    class MyA
    {
        public MyA(int ax, int ay)
        {            
            this.ax = ax;
            this.ay = ay;            
        }
        public MyA Copy()
        {
            return new MyA(ax, ay);
        }
        public override string ToString()
        {
            return ax + ", "+ ay + " -> " + CRC;
        }
        public string MyToString01()
        {
            return "(ax=" + ax + ", ay=" + ay + ", crc=" + CRC+")";
        }
        private int CrC()
        {
            return 2 * (ax % 2) + ay % 2;
        }

       
        public int CRC
        {
            get
            {
                SetCrC();
                return cRc;
            }
        }
        private void SetCrC()
        {
            cRc = CrC();
        }

        public int ax;
        public int ay;

        private int cRc;
    }
}
