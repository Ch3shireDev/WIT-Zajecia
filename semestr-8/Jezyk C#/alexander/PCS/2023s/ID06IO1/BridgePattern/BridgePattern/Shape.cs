using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BridgePattern
{
    public abstract class Shape
    {
        public static void ParseLambdas(string text, params Action<float>[] pl)
        {
            string[] tb = text.Split(" \t;".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            int size = tb.Length;
            if (size != pl.Length) throw new ArgumentException("Unexpected prameters count");
            for (int i = 0; i < size; ++i) pl[i](float.Parse(tb[i]));
        }
        public abstract void Draw(Graphics g);
        public abstract string ToXml();
    }
}
