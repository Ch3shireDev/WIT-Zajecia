using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class SportsmenStrategySwimButterfly: SportsmenStrategySwim
    {
        public string ExecuteSwim() { return "Butterfly swimming"; }
        public override string ToString()
        {
            return "Butterfly";
        }
    }
}
