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
        public Sportsmen(string surname) { this.surname = surname; }
        public string Jump() { return "Jumping"; }
        public string Run() { return "Running"; }
        public string Swim() { return "Swimming"; }
        public string execute(SportsmenCommand cmd) { return surname + ": " + cmd.execute(this); }
    }
}
