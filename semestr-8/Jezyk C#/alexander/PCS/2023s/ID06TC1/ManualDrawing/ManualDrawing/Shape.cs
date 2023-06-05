using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ManualDrawing
{
    abstract class Shape
    {
        public delegate void SI(int v);
        public void ParseParameters(string parameters, params SI[] si)
        {
            string[] split = parameters.Split(" \t;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int size = si.Length;
            if (size != split.Length) throw new ArgumentException("Invalid array size");
            for (int i = 0; i < size; ++i) si[i](int.Parse(split[i]));
            //foreach (SI f in si) f(int.Parse(split[i]));
        }
        /*
        public int[] ParseParameters(string parameters,int expectedSize)
        {
            string[] split = parameters.Split(" \t;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int size = split.Length;
            if (size != expectedSize) throw new ArgumentException("Invalid array size");
            //if (size != expectedSize) return null;
            int[] param = new int[size];
            for (int i = 0; i < size; ++i) param[i] = int.Parse(split[i]);
            return param;
        }
        */
        public abstract void Draw(Graphics g);
    }
}
