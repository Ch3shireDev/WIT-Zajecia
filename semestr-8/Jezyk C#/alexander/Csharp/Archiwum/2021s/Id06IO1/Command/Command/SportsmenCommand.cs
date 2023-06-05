using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface SportsmenCommand
    {
        string execute(Sportsmen s);
    }

    public class SportsmenCommandRun:SportsmenCommand
    {
        public string execute(Sportsmen s) { return s.Run(); }
        public override string ToString() { return "Run"; }
    }
    public class SportsmenCommandSwim:SportsmenCommand
    {
        public string execute(Sportsmen s) { return s.Swim(); }
        public override string ToString() { return "Swim"; }
    }
    public class SportsmenCommandJump:SportsmenCommand
    {
        public string execute(Sportsmen s) { return s.Jump(); }
        public override string ToString() { return "Jump"; }
    }
    public abstract class SportsmenCommandComplex:SportsmenCommand
    {
        private string name;
        public SportsmenCommandComplex(string name) { this.name=name; }
        public override string ToString() { return name; }
    }
    public class SportsmenCommandTrening:SportsmenCommandComplex
    {
        private List<SportsmenCommand> list;
        public SportsmenCommandTrening(string name,List<SportsmenCommand> list):base(name) { this.list=list; }
        public string execute(Sportsmen s)
        {
            StringBuilder sb=new StringBuilder();
            bool first=true;
            foreach(SportsmenCommand cmd in list)
            {
                if(first) first=false; else sb.Append(", ");
                sb.Append(cmd.execute(s));
            }
            return sb.ToString(); 
        }
    }
    public class SportsmenCommandMultiply:SportsmenCommandComplex
    {
        private SportsmenCommand cmd;
        private int count;
        public SportsmenCommandMultiply(string name,SportsmenCommand cmd,int count):base(name)
        {
            this.cmd=cmd;
            this.count=count;
        }
        public string execute(Sportsmen s)
        {
            return string.Format("%d x %s",count,cmd.execute(s));
        }
    }
}
