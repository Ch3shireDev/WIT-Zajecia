using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Sportsmen
    {
        private string name;
        private StrategyRun srun;
        private StrategyJump sjump;
        private StrategySwim sswim;
        public Sportsmen(string name,StrategyRun srun,StrategyJump sjump,StrategySwim sswim)
        {
            this.name=name; 
            this.srun=srun;
            this.sjump=sjump;
            this.sswim=sswim;
        }
        public string Run() { return srun.execute(); }
        public string Swim() { return sswim.execute(); }
        public string Jump() { return sjump.execute(); }
        public string execute(SportsmenCommand cmd) { return name+": "+cmd.execute(this); }
    }
}
