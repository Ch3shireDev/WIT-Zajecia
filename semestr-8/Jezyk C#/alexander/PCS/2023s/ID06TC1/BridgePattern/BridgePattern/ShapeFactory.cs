using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class ShapeFactory
    {
        private delegate ShapeBase ShapeMaker(string Parameters);
        private static readonly Dictionary<string, ShapeMaker> map = new Dictionary<string, ShapeMaker>()
        {
            {"Circle",    (Parameters) => new ShapeCircle(Parameters)    },
            {"Triangle",  (Parameters) => new ShapeTriangle(Parameters)  },
            {"Rectangle", (Parameters) => new ShapeRectangle(Parameters) },
        };
        public static readonly string[] Kinds = map.Keys.OrderBy(s => s).ToArray();
        public static ShapeBase make(string kind, string parameters)
        {
            return map[kind](parameters);
        }
    }
}
