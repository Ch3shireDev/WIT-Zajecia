using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy

{
    internal class SportsmenStrategyJumpPole : SportsmenStrategyJump
    {
        public string ExecJump()
        {
            return "Poling";
        }
        public override string ToString()
        {
            return "Pole";
        }
    }
}