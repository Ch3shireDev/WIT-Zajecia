using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class SportsmenStrategyRunHurdles : SportsmenStrategyRun
    {
        public string ExecuteRun() { return "Hurdling"; }
        public override string ToString() { return "Hurdles"; }
    }
}
