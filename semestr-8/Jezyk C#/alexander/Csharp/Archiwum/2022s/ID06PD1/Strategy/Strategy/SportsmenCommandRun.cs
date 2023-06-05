using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class SportsmenCommandRun : SportsmenCommand
    {
        public string execute(Sportsmen sportsmen) { return sportsmen.Run(); }
        public override string ToString() { return "Run"; }
    }
}
