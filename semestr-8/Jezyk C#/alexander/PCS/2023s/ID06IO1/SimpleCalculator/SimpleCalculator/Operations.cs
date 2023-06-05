using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Operations
    {
        private delegate double Calculate(double a, double b);
        private static readonly Dictionary<string, Calculate> map = new Dictionary<string, Calculate>()
        {
            {"+",(a,b) => a+b},
            {"-",(a,b) => a-b},
            {"*",(a,b) => a*b},
            {"/",(a,b) => a/b},
        };
        public static readonly string[] keys = map.Keys.OrderBy(s => s).ToArray();
        public static double calc(double a, string operation, double b)
        {
            //Calculate fun = map[operation];
            //return fun(a, b);
            return map[operation](a, b);
        }
    }
}
