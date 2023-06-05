using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    abstract class OperationFactory
    {
        private delegate double Operation(double a, double b);
        private static Dictionary<string, Operation> map = new Dictionary<string, Operation>()
        {
            {"+",(a,b) => a+b},
            {"-",(a,b) => a-b},
            {"*",(a,b) => a*b},
            {"/",(a,b) => a/b},
            {"^",(a,b) => Math.Pow(a,b)},
        };
        public static string[] keys = map.Keys.OrderBy(s => s).ToArray();
        public static double calculate(double a, string operation, double b)
        {
            return map[operation](a, b);
        }
    }
}
