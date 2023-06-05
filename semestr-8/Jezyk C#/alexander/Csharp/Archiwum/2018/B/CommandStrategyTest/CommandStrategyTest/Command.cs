using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandStrategyTest
{
    abstract class Command
    {
        public string Execute(Sportsman s)
        {
            return s.name + ": " + execute(s);
        }
        public abstract string execute(Sportsman s);
    }
    class CommandRun : Command
    {
        public override string execute(Sportsman s) { return s.Run(); }
    }
    class CommandJump : Command
    {
        public override string execute(Sportsman s) { return s.Jump(); }
    }
    class CommandSwim : Command
    {
        public override string execute(Sportsman s) { return s.Swim(); }
    }
    class Trening : Command
    {
        private Command[] lst;
        public Trening(Command[] lst) { this.lst = lst; }
        public override string execute(Sportsman s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Command cmd in lst) sb.Append(" + ").Append(cmd.execute(s));
            return sb.ToString().Substring(3);
        }
    }
}
