using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Sportsmen
    {
        //private string _name;
        //public string name { get { return _name; } private set { _name = value; } }
        public string name { get; private set; }
        private SportsmenStrategyRun run;
        public Sportsmen(string name, SportsmenStrategyRun run) { this.name = name; this.run = run; }
        public string Run() { return run.Run(); }
        public string Jump() { return "Jumping"; }
        public string Swim() { return "Swiming"; }
        public string execute(SportsmenCommand command) { return name+": "+command.execute(this); }
    }
}
