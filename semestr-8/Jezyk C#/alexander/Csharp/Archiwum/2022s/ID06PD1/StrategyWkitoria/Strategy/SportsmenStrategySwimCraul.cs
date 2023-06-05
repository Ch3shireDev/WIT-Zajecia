using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class SportsmenStrategySwimCraul : SportsmenStrategySwim
    {
        public string ExecSwim()
        {
            return "Crauling";
        }
        public override string ToString()
        {
            return "Craul";
        }
    }
}
