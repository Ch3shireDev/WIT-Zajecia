using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal abstract class SportsmenStrategySwimFactory
    {
        public static readonly SportsmenStrategySwim[] strategies
            =
            new SportsmenStrategySwim[]
            {
                new SportsmenStrategySwimFrog(),
                new SportsmenStrategySwimButterfly(),
                new SportsmenStrategySwimCraul(),
            }
            .OrderBy(st => st.ToString())
            .ToArray()
            ;
    }
}
