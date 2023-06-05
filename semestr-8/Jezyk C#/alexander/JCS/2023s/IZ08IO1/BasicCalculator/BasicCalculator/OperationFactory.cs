using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class OperationFactory
    {
        private delegate double Operatation(double a, double b);
        private static readonly Dictionary<string, Operatation> factory = new Dictionary<string, Operatation>()
        {
            {"+",(a,b) => a+b },
            {"-",(a,b) => a-b },
            {"*",(a,b) => a*b },
            {"/",(a,b) => a/b },
            {"^",(a,b) => Math.Pow(a,b) },
        };
        public static readonly string[] keys = factory.Keys.OrderBy(key => key).ToArray();
        public static double calculate(double a, string op, double b)
        {
            //Operatation opr = factory[op];
            //return opr(a, b);
            return factory[op](a, b);
        }
    }
}
