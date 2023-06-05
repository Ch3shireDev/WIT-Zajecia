using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class SportsmenStrategyJumpLong : SportsmenStrategyJump
    {
        public string ExecuteJump() { return "Long jumping"; }
        public override string ToString() { return "Long"; }
    }
}
