using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandStrategyTest
{
    class Sportsman
    {
        public string name { get; set; }
        private StrategyRun run;
        StrategyJump jump;
        StrategySwim swim;
        public Sportsman(string name,StrategyRun run, StrategyJump jump, StrategySwim swim)
        {
            this.run = run;
            this.jump = jump;
            this.swim = swim;
            this.name = name;
        }
        public string Run() { return run.execute(); }
        public string Jump() { return jump.execute(); }
        public string Swim() { return swim.execute(); }
    }
}
