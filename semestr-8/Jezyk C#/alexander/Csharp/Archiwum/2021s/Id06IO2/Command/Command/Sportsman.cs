using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Sportsman
    {
        private string name;
        public Sportsman(string name) { this.name=name; }
        public string Run() { return "Running"; }
        public string Jump() { return "Jumping"; }
        public string Swim() { return "Swimming"; }
        public string execute(SportsmenCommand cmd) { return name+": "+cmd.execute(this); }
    }
}
