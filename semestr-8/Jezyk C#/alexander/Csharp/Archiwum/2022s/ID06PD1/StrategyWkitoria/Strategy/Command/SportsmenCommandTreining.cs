using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class SportsmenCommandTreining:SportsmenCommandComplex
    {
        private List<SportsmenCommand> cmds;
        public SportsmenCommandTreining(string name, List<SportsmenCommand> cmds): base(name) { this.cmds = cmds; }

        public override string execute(Sportsmen sportsmen)
        {
            StringBuilder sb = new StringBuilder().Append('{');

            for(int i = 0; i< cmds.Count; ++i) 
            { 
                if (i > 0) sb.Append(", ");
                sb.Append(cmds[i].execute(sportsmen)); 
            }
            return sb.Append('}').ToString();
        }
    }  
}
