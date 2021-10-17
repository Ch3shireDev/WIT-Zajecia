using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyANamespace;
using MyUtilityNamespace;

namespace MyAANamespace
{
    class MyAA
    {
        public MyAA(MyA ax, MyA ay)
        {
            this.ax = ax.Copy();
            this.ay = ay.Copy();
        }
        public MyAA Copy()
        {
            return new MyAA(ax.Copy(), ay.Copy());
        }
        public override string ToString()
        {
            return ax + "; " + ay + "; -> " + CRC;
        }
        public int CRC
        {
            get
            {
                SetCrC();
                return cRc;
            }
        }
        private int CrC()
        {
            return 4 * ax.CRC + ay.CRC;
        }
        private void SetCrC()
        {
            cRc = CrC();
        }

        public MyA ax;
        public MyA ay;

        private int cRc;
    }
}
//35, 25, 15, 10, 8, 8, 7, 7, 7