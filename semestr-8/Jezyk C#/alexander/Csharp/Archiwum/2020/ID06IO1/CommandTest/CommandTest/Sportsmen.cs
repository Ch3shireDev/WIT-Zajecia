using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandTest
{
    class Sportsman
    {
        private string name;
        public Sportsman(string name) { this.name = name; }
        public string Run() { return "Running"; }
        public string Jump() { return "Jumping"; }
        public string Swim() { return "Swimming"; }
        public string execute(SportsmanCommand cmd) { return name+": "+cmd.execute(this); }
    }
    class SportsmanCommandFabric
    {
        public static readonly SportsmanCommand[] basic = new SportsmanCommand[]
        {
            new SportsmanRun(),
            new SportsmanJump(),
            new SportsmanSwim(),
        };
    }
    interface SportsmanCommand
    {
        string execute(Sportsman s);
    }
    class SportsmanRun : SportsmanCommand
    {
        public string execute(Sportsman s) { return s.Run(); }
        public override string ToString() { return "Run"; }
    }
    class SportsmanJump : SportsmanCommand
    {
        public string execute(Sportsman s) { return s.Jump(); }
        public override string ToString() { return "Jump"; }
    }
    class SportsmanSwim : SportsmanCommand
    {
        public string execute(Sportsman s) { return s.Swim(); }
        public override string ToString() { return "Swim"; }
    }
    interface SportsmanCommandComplex : SportsmanCommand
    {
    }
    class SportsmanCommandMultiply : SportsmanCommandComplex
    {
        private SportsmanCommand cmd;
        private int count;
        public SportsmanCommandMultiply(int count, SportsmanCommand cmd)
        {
            this.count = count;
            this.cmd = cmd;
        }
        private static readonly string FMTNORM = "{0} x {1}";
        private static readonly string FMTTRAIN = "{0} x [{1}]";
        public string execute(Sportsman s)
        {
            bool tr = (cmd is SportsmanCommandTraining);
            return string.Format(tr ? FMTTRAIN : FMTNORM, count, cmd.execute(s));
        }
        public override string ToString() { return count+"x"+cmd; }
    }
    class SportsmanCommandTraining : SportsmanCommandComplex
    {
        private List<SportsmanCommand> cmds;
        private string name;
        public SportsmanCommandTraining(string name,List<SportsmanCommand> cmds)
        {
            this.name = name;
            this.cmds = cmds;
        }
        public string execute(Sportsman s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < cmds.Count; ++i)
            {
                if (i > 0) sb.Append(", ");
                sb.Append(cmds[i].execute(s));
            }
            return sb.ToString();
        }
        public override string ToString() { return name; }
    }
}
