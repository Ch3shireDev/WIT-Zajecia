using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatern
{
    public class ShapeFactory
    {
        private delegate Shape ShapeMaker(string parameters);
        private static Dictionary<string, ShapeMaker> map = new Dictionary<string, ShapeMaker>()
        {
            {"Circle",    (parameters) => new ShapeCircle(parameters)    },
            {"Rectangle", (parameters) => new ShapeRectangle(parameters) },
            {"Triangle",  (parameters) => new ShapeTriangle(parameters)  },
        };
        public static string[] Kinds = map.Keys.OrderBy(kind => kind).ToArray();
        public static Shape make(string kind, string parameters)
        {
            return map[kind](parameters);
        }
    }
}
