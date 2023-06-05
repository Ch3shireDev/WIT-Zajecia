using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Sportsmen
    {
        //public string _name;
        //public string name { get { return _name; } private set { _name = value; } }
        public string name { get; private set; }
        private SportsmenStrategyJump jump;
        public Sportsmen(string name,SportsmenStrategyJump jump)
        {
            this.name = name;
            this.jump = jump;
        }
        public string Run() { return "Runing"; }
        public string Swim() { return "Swimming"; }
        public string Jump() { return jump.Jump(); }
        public string execute(SportsmenCommand command)
        {
            return name + ": " + command.execute(this);
        }
    }
}
