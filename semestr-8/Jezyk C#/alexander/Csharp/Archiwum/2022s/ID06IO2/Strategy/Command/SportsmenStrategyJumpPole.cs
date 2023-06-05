using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class SportsmenStrategyJumpPole : SportsmenStrategyJump
    {
        public string Jump() { return "Poling"; }
        public override string ToString() { return "Pole"; }
    }
}
