using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BridgePatern
{
    public abstract class Shape
    {
        public static void ParseParams(string text, params Action<float>[] tb)
        {
            int size = tb.Length;
            string[] cells = text.Split("\t ;".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            if (size != cells.Length) throw new Exception("Invalid parameters count");
            for (int i = 0; i < size; ++i) tb[i](float.Parse(cells[i]));
        }
        public abstract void Draw(Graphics g);
        public abstract string ToXml();
    }
}
