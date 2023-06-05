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
        public delegate void SF(float value);
        public static void ParseParams(string text, params Action<float>[] tb)
        {
            int size = tb.Length;
            string[] cells = text.Split("\t ;".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            if (size != cells.Length) throw new Exception("Invalid parameters count");
            for (int i = 0; i < size; ++i) tb[i](float.Parse(cells[i]));
        }
        public static float Scale(float value,float shift,float scale)
        {
            return value * scale + shift;
        }

        public abstract void Draw(Graphics g, PointF shift, float scale);
        public abstract float minX();
        public abstract float maxX();
        public abstract float minY();
        public abstract float maxY();
    }
}
