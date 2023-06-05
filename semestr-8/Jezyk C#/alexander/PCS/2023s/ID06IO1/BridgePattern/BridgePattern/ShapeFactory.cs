using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class ShapeFactory
    {
        private delegate Shape ShapeMaker(string parameters);
        private static Dictionary<string, ShapeData> map = new Dictionary<string, ShapeData>()
        {
            {"Circle",    new ShapeData((parameters) => new ShapeCircle(parameters),"100 100 90")    },
            {"Triangle",  new ShapeData((parameters) => new ShapeTriangle(parameters),"10 10 190 95 95 190")  },
            {"Rectangle", new ShapeData((parameters) => new ShapeRectangle(parameters),"10 10 190 190") },
        };
        public static string[] Kinds = map.Keys.OrderBy(kind => kind).ToArray();
        public static Shape make(string kind,string parameters) { return map[kind].maker(parameters); }
        public static string paremeters(string kind) { return map[kind].parameters; }
        private class ShapeData
        {
            public ShapeMaker maker { get; private set; }
            public string parameters { get; private set; }
            public ShapeData(ShapeMaker maker, string parameters)
            {
                this.maker = maker;
                this.parameters = parameters;
            }
        }
    }
}
