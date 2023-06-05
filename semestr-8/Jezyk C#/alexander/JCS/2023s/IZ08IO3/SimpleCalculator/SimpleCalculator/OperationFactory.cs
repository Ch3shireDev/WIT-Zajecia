using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class OperationFactory
    {
        private delegate double Operation(double a, double b);
        private static readonly Dictionary<string, Operation> factory = new Dictionary<string, Operation>()
        {
            {"+",(a,b) => a+b},
            {"-",(a,b) => a-b},
            {"*",(a,b) => a*b},
            {"/",(a,b) => a/b},
        };
        public static readonly string[] Keys = factory.Keys.OrderBy(s => s).ToArray();
        public static double calculate(double a, string key, double b)
        {
            //Operation op = factory[key];
            //return op(a, b);
            return factory[key](a, b);
        }
    }
}
