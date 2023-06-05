
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class SportsmenStrategySwimFrog : SportsmenStrategySwim
    {
        public string ExecSwim()
        {
            return "Froging";
        }
        public override string ToString()
        {
            return "Frog";
        }
    }
}
