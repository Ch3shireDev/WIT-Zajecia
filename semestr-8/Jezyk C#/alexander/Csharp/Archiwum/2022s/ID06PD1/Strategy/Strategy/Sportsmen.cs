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
        public Sportsmen(string surname, SportsmenStrategyRun stRun)
        {
            this.surname = surname;
            this.stRun = stRun;
        }
        public string Jump() { return "Jumping"; }
        public string Run() { return stRun.Run(); }
        public string Swim() { return "Swimming"; }
    }
}
