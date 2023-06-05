using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Sportsman
    {
        private string name;
        private StrategyRun strun;
        private StrategyJump stjump;
        private StrategySwim stswim;
        public Sportsman(string name, StrategyRun strun, StrategyJump stjump, StrategySwim stswim) 
        {
            this.name=name;
            this.strun = strun;
            this.stjump = stjump;
            this.stswim = stswim;
        }
        public string Run() { return strun.execute(); }
        public string Jump() { return stjump.execute(); }
        public string Swim() { return stswim.execute(); }
        public string execute(SportsmenCommand cmd) { return name+": "+cmd.execute(this); }
    }
}
