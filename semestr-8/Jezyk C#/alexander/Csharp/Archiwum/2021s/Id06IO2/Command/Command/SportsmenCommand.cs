using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class SportsmenCommand
    {
        public virtual string execute(Sportsman s);
    }

    public class SportsmenCommandRun:SportsmenCommand
    {
        public override string execute(Sportsman s) { return s.Run(); }
    }
    public class SportsmenCommandJump:SportsmenCommand
    {
        public override string execute(Sportsman s) { return s.Jump(); }
    }
    public class SportsmenCommandSwim:SportsmenCommand
    {
        public override string execute(Sportsman s) { return s.Swim(); }
    }
    public class SportsmenCommandComplex:SportsmenCommand
    {
        private string name;
        public SportsmenCommandComplex(string name) { this.name=name; }
        public string GetName() { return name; }
    }
    public class SportsmenCommandTrening:SportsmenCommandComplex
    {
        private List<SportsmenCommand> list=new List<SportsmenCommand>();
        public SportsmenCommandTrening(string name,List<SportsmenCommand> list):base(name) { this.list=list; }
        public override string execute(Sportsman s)
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
    public class SportsmenCommandRepeat:SportsmenCommandComplex
    {
        private SportsmenCommand cmd;
        private int count;
        public SportsmenCommandRepeat(string name,SportsmenCommand cmd,int count):base(name)
        {
            this.cmd=cmd; 
            this.count=count;
        }
        public override string execute(Sportsman s)
        {
            return string.Format("%d x %s",count,cmd.execute(s));
        }
    }
}
