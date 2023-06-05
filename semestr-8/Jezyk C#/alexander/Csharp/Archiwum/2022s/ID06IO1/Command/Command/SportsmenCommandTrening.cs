using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class SportsmenCommandTrening: SportsmenCommandComplex
    {
        private readonly List<SportsmenCommand> cmds;
        public SportsmenCommandTrening(string name, List<SportsmenCommand> cmds) :base(name)
        {
            this.cmds = cmds;
        }
        public override string execute(Sportsmen sportsmen)
        {
            StringBuilder sb = new StringBuilder();
            /*
            bool first = true;
            foreach(SportsmenCommand cmd in cmds)
            {
                //if (!first) sb.Append(", ");
                //first = false;
                if (first) first = false; else sb.Append(", ");
                sb.Append(cmd.execute(sportsmen));
            }
            */
            for(int i=0;i<cmds.Count;++i)
            {
                if (i>0) sb.Append(", ");
                sb.Append(cmds[i].execute(sportsmen));
            }
            return "{ "+sb.ToString()+" }";
        }
    }
}
