using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Sportsmen
    {
        //public string _name;
        //public string name { get { return _name; } private set { _name = value; } }
        public string name { get; private set; }
        public Sportsmen(string name)
        {
            this.name = name;
        }
        public string Run() { return "Runing"; }
        public string Swim() { return "Swimming"; }
        public string Jump() { return "Jumping"; }
        public string execute(SportsmenCommand command)
        {
            return name + ": " + command.execute(this);
        }
    }
}
