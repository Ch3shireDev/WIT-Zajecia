using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ManualDrawing
{
    public delegate void SF(float v);
    abstract class Shape
    {
        public static void ParseLambdas(string text, params SF[] pl)
        {
            string[] tb = text.Split(" \t;".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            int size = tb.Length;
            if (size != pl.Length) throw new ArgumentException("Unexpected prameters count");
            for (int i = 0; i < size; ++i) pl[i](float.Parse(tb[i]));
        }
        /*
        public static float[] ParseParameters(string text,int size)
        {
            string[] tb = text.Split(" \t;".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            if (tb.Length != size) throw new ArgumentException("Unexpected prameters count");
            float[] ret = new float[size];
            for (int i = 0; i < size; ++i) ret[i] = float.Parse(tb[i]);
            return ret;
        }
        */
        public abstract void Draw(Graphics g, PointF shift, float scala);
        public static float Sc(float value,float shift,float scala)
        {
            return (value-shift)*scala;
        }

        public abstract float MinX();
        public abstract float MaxX();
        public abstract float MinY();
        public abstract float MaxY();
    }
}
