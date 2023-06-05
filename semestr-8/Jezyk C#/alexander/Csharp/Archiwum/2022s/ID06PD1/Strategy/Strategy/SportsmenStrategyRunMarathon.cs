using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class SportsmenStrategyRunMarathon: SportsmenStrategyRun
    {
        public string Run() { return "Marathoning"; }
        public override string ToString() { return "Marathon"; }
    }
}
