using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal abstract class SportsmenStrategyRunFactory
    {
        public static readonly SportsmenStrategyRun[] Strategies
            =
            (
                new SportsmenStrategyRun[]
                {
                    new SportsmenStrategyRunMaraton(),
                    new SportsmenStrategyRunSprint(),
                    new SportsmenStrategyRunHurdles(),
                }
            )
            .OrderBy(st => st.ToString())
            .ToArray()
            ;
    }
}
