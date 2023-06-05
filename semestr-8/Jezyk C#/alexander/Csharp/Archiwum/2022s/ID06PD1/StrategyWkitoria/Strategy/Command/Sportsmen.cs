using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{

    internal class Sportsmen
    {
        public string surname { get; private set; }
        private SportsmenStrategyRun stRun;
        private SportsmenStrategyJump stJump;
        private SportsmenStrategySwim stSwim;

        public Sportsmen(string surname, SportsmenStrategyRun stRun, SportsmenStrategyJump stJump, SportsmenStrategySwim stSwim)
        {
            this.surname = surname;
            this.stRun = stRun;
            this.stJump = stJump;
            this.stSwim = stSwim;
        }

        public string Run() { return stRun.ExecuteRun(); }
        public string Jump() { return stJump.ExecuteJump(); }
        public string Swim() { return stSwim.ExecuteSwim(); }   
        
        public string execute(SportsmenCommand command)
        {
            return surname + ": " + command.execute(this);
        }
    }
}
