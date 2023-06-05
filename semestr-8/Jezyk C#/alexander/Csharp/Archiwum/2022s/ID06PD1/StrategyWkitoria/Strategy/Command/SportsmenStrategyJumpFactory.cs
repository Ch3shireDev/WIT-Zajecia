using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal abstract class SportsmenStrategyJumpFactory
    {
        public static readonly SportsmenStrategyJump[] Strategies
        =
            (
                new SportsmenStrategyJump[]
                {
                    new SportsmenStrategyJumpHigh(),
                    new SportsmenStrategyJumpLong(),
                    new SportsmenStrategyJumpPole(),
                }
            )
            .OrderBy(s => s.ToString())
            .ToArray()
        ;
    }
}
