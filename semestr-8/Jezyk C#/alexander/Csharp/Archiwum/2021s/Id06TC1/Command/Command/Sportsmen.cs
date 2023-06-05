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
        public Sportsmen(string name) { this.name=name; }
        public String Run() { return "Running"; }
        public String Jump() { return "Jumping"; }
        public String Swim() { return "Swimming"; }
        public String execute(SportsmenCommand cmd) { return name + ": " + cmd.execute(this); }
    }
}
