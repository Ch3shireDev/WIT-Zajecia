using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class SportsmenCommandTrening: SportsmenCommandComplex
    {
        private List<SportsmenCommand> commands;
        public SportsmenCommandTrening(string name, List<SportsmenCommand> commands) :base(name) { this.commands = commands; }

        public override string execute(Sportsmen sportsmen)
        {
            StringBuilder sb = new StringBuilder().Append('{');
            for(int i=0;i<commands.Count;++i)
            {
                if (i > 0) sb.Append(", ");
                sb.Append(commands[i].execute(sportsmen));
            }
            return sb.Append('}').ToString();
        }
    }
}
