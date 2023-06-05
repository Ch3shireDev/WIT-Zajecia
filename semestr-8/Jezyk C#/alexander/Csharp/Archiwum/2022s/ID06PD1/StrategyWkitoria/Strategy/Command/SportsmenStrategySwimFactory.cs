using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal abstract class SportsmenStrategySwimFactory
    {
        public static readonly SportsmenStrategySwim[] Strategies
        =
            (
                new SportsmenStrategySwim[]
                {
                    new SportsmenStrategySwimButterfly(),
                    new SportsmenStrategySwimFrog(),
                    new SportsmenStrategySwimCrawl(),
                }
            )
            .OrderBy(s => s.ToString())
            .ToArray()
        ;
    }
}
