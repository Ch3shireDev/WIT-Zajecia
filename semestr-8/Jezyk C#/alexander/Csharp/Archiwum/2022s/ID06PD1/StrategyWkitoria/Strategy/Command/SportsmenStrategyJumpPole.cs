using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class SportsmenStrategyJumpPole : SportsmenStrategyJump
    {
        public string ExecuteJump() { return "Pole jumping"; }
        public override string ToString() { return "Pole"; }
    }
}

