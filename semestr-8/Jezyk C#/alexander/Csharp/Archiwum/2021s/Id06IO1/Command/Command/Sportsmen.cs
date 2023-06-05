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
        public string Run() { return "Runing"; }
        public string Swim() { return "Swimming"; }
        public string Jump() { return "Jumping"; }
    }
}
