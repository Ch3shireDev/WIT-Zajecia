using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Sportsmen
    {
        //private string _name;
        //public string name { get { return _name; } private set { _name = value; } }
        public string name { get; private set; }
        public Sportsmen(string name) { this.name = name; }
        public string Run() { return "Running"; }
        public string Jump() { return "Jumping"; }
        public string Swim() { return "Swiming"; }
        public string execute(SportsmenCommand command) { return name+": "+command.execute(this); }
    }
}
