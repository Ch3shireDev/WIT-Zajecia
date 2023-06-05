using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class ShapeBase
    {
        protected void Parse(string paremeters, params Action<int>[] setters)
        {
            string[] values = paremeters.Split(" \t;".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            if (values.Length != setters.Length) throw new ArgumentException("Unexpected parameters count");
            for (int i = 0; i < setters.Length; ++i) setters[i](int.Parse(values[i]));
        }
        public abstract void Draw(Graphics g);
        public abstract String ToXml();
    }
}
