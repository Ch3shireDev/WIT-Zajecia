using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class SportsmenStrategyRunSprint : SportsmenStrategyRun
    {
        public string ExecuteRun() { return "Sprinting"; }
        public override string ToString() { return "Sprint"; } 
    }
}
