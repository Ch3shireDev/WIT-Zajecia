using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandTest
{
    class Sportsmen
    {
        private string name;
        public Sportsmen(string name) { this.name = name; } 
        public string run() { return "Running"; }
        public string jump() { return "Jumping"; }
        public string swim() { return "Swimming"; }
        public string execute(SportsmenCommand cmd) { return name+": "+cmd.execute(this); }
    }

    interface SportsmenCommand
    {
        string execute(Sportsmen s);
    }

    class SportsmenRun : SportsmenCommand
    {
        public string execute(Sportsmen s) { return s.run(); }
        public override string ToString() { return "Run"; }
    }
    class SportsmenJump : SportsmenCommand
    {
        public string execute(Sportsmen s) { return s.jump(); }
        public override string ToString() { return "Jump"; }
    }
    class SportsmenSwim : SportsmenCommand
    {
        public string execute(Sportsmen s) { return s.swim(); }
        public override string ToString() { return "Swim"; }
    }
    interface SportsmenComplexCommand : SportsmenCommand
    {
    }
    class SportsmenMultiplyCommand : SportsmenComplexCommand
    {
        private SportsmenCommand cmd;
        private int count;
        public SportsmenMultiplyCommand(int count, SportsmenCommand cmd)
        {
            this.count = count;
            this.cmd = cmd;
        }
        public string execute(Sportsmen s)
        {
            StringBuilder sb = new StringBuilder();
            return string.Format("{0} x ({1})", count, cmd.execute(s));
        }
        public override string ToString() { return count+"x"+cmd; }
    }
    class SportsmenSequenceCommand : SportsmenComplexCommand
    {
        private SportsmenCommand[] tb;
        private string name;
        public SportsmenSequenceCommand(string name,SportsmenCommand[] tb)
        {
            this.name = name;
            this.tb = tb;
        }
        public string execute(Sportsmen s)
        {
            StringBuilder sb = new StringBuilder();
            bool first=true;
            foreach (SportsmenCommand cmd in tb)
            {
                if (first) first = false;
                else sb.Append(", ");
                sb.Append(cmd.execute(s));
            }
            return sb.ToString();
        }
        public override string ToString() { return name; }
    }
}
