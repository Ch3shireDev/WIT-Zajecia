using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class SportsmenCommandMultiply: SportsmenCommandComplex
    {
        private uint count;
        private SportsmenCommand command;
        public SportsmenCommandMultiply(string name, uint count, SportsmenCommand command) : base(name)
        {
            this.count = count;
            this.command = command;
        }

        public override string execute(Sportsmen sportsmen)
        {
            return count.ToString() + " * " + command.execute(sportsmen);
        }
    }
}
