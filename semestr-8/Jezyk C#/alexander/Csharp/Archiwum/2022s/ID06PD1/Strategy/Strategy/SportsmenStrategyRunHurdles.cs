using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class SportsmenStrategyRunHurdles : SportsmenStrategyRun
    {
        public string Run() { return "Hurdlesing"; }
        public override string ToString() { return "Hurdles"; }
    }
}
