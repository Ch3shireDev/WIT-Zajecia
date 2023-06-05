using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class SportsmenStrategySwimCrawl : SportsmenStrategySwim
    {
        public string ExecuteSwim() { return "Crawl swimming"; }
        public override string ToString()
        {
            return "Crawl";
        }
    }
}
