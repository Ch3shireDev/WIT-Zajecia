using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class SportsmenCommandTrening: SportsmenCommandComplex
    {
        private readonly List<SportsmenCommand> cmds;

        public SportsmenCommandTrening(string name,List<SportsmenCommand> cmds):base(name)
        {
            this.cmds= cmds;
        }

        public override string execute(Sportsmen sportsmen)
        {
            StringBuilder sb = new StringBuilder();
            bool first = true;
            foreach (SportsmenCommand cmd in cmds)
            {
                if (first) first = false; else sb.Append(", ");
                sb.Append(cmd.execute(sportsmen));                
            }
            return sb.ToString();
        }
    }
}
