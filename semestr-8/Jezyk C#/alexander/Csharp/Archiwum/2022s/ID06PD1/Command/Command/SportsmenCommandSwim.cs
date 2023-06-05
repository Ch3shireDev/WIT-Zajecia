using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class SportsmenCommandSwim : SportsmenCommand
    {
        public string execute(Sportsmen sportsmen) { return sportsmen.Swim(); }
        public override string ToString() { return "Swim"; }
    }
}
