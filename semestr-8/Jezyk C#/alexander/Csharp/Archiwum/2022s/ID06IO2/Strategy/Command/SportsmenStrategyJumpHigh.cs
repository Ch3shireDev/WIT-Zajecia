using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class SportsmenStrategyJumpHigh : SportsmenStrategyJump
    {
        public string Jump() { return "Highing"; }
        public override string ToString() { return "High"; }
    }
}
