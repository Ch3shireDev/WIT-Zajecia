using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface StrategyRun
    {
        string execute();
    }
    public abstract class StrategyRunFactory
    {
        private static Dictionary<string,StrategyRun> map=new Dictionary<string,StrategyRun>()
        {
            {"Marathon",new StrategyRunMarathon()},
            {"Strint",new StrategyRunStrint()},
        };
        public static StrategyRun get(string kind) { return map[kind]; }
        public static List<string> keys { get { return map.Keys.OrderBy((kind)=>kind).ToList(); } }
    }
    public class StrategyRunMarathon:StrategyRun
    {
        public string execute() { return "Marathoning"; }
    }
    public class StrategyRunStrint:StrategyRun
    {
        public string execute() { return "Strinting"; }
    }
}
