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
        public String Run() { return run==null?"Running":run.execute(); }
        public String Jump() { return "Jumping"; }
        public String Swim() { return "Swimming"; }
        public String execute(SportsmenCommand cmd) { return name + ": " + cmd.execute(this); }
    }
}
