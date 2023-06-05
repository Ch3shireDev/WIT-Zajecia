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
                new SportsmenStrategyRun[]
                {
                    new SportsmenStrategyRunHurdles(),
                    new SportsmenStrategyRunMarathon(),
                    new SportsmenStrategyRunSprint(),
                }
                .OrderBy(s => s.ToString()).ToArray()
            ;
            
    }
}
