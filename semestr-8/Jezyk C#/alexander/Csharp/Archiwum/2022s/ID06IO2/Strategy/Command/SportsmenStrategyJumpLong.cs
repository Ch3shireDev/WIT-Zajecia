using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class SportsmenStrategyJumpLong : SportsmenStrategyJump
    {
        public string Jump() { return "Longing"; }
        public override string ToString() { return "Long"; }
    }
}
