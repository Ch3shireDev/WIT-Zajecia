using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class SportsmenCommandJump : SportsmenCommand
    {
        public string execute(Sportsmen sportsmen) { return sportsmen.Jump(); }
        public override string ToString() { return "Jump"; }
    }
}
