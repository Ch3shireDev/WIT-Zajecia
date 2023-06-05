using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy

{
    internal class SportsmenStrategyJumpHigh : SportsmenStrategyJump
    {
        public string ExecJump()
        {
            return "Highing";
        }
        public override string ToString()
        {
            return "High";
        }
    }
}