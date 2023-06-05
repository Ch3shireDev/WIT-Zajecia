using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeTest
{
    delegate Figure FigureMaker(int[] Parameters);
    public class FigureFabric
    {
        private static readonly Dictionary<String, FigureMaker> map = new Dictionary<string, FigureMaker>()
        {
            {"Circle",(Parameters) => new FigureCircle(Parameters)},
            {"Triangle",(Parameters) => new FigureTriangle(Parameters)},
            {"Rectangle",(Parameters) => new FigureRectangle(Parameters)},
        };
        public static string[] Kinds
        {
            get { return map.Keys.OrderBy((s) => s).ToArray(); }
        }
        public static Figure make(string Kind, string Parameters)
        {
            string[] items = Parameters.Split(" \t,;".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            int[] tb = new int[items.Length];
            for (int i = 0; i < tb.Length; ++i) tb[i] = int.Parse(items[i]);
            return map[Kind](tb);
        }
    }
}
