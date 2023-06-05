using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Sportsmen
    {
        private string name;
        private StrategyRun run;
        public Sportsmen(string name,StrategyRun run) 
        {
            this.name=name; 
            this.run=run;
        }
        public string Run() { return run.execute(); }
        public string Jump() { return "Jumping"; }
        public string Swim() { return "Swimming"; }
        public string execute(SportsmenCommand cmd)
        {
            return name + ": " + cmd.execute(this);
        }
    }
}
