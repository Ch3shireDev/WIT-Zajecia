using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class SportsmenCommandMultiply : SportsmenCommandComplex
    {
        private uint count;
        private SportsmenCommand cmd;
        public SportsmenCommandMultiply(string name, uint count, SportsmenCommand cmd) : base(name)
        {
            this.count = count;
            this.cmd = cmd;
        }
        public override string execute(Sportsmen sportsmen)
        {
            return count.ToString()+" * "+cmd.execute(sportsmen);
        }
    }
}
