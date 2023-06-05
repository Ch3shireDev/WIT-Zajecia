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
        private static readonly Dictionary<string, Operation> factory = new Dictionary<string, Operation>()
        {
            {"+",(a,b) => a+b },
            {"-",(a,b) => a-b },
            {"*",(a,b) => a*b },
            {"/",(a,b) => a/b },
        };
        public static readonly string[] keys = factory.Keys.OrderBy(key => key).ToArray();
        public static double calculate(double a, string key, double b)
        {
            //Operation operation = factory[key];
            //return operation(a, b);
            return factory[key](a, b);
        }
    }
}
