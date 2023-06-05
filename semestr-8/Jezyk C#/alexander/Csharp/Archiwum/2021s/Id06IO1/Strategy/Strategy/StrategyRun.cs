using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface StrategyRun
    {
        string execute();
    }
    public abstract class StrategyRunFactory
    {
        private static Dictionary<string, StrategyRun> map = new Dictionary<string, StrategyRun>()
        {
            {"Marathon",new StrategyRunMarathon()},
            {"Sprinting",new StrategyRunSprint()},
        };
        public static StrategyRun make(string kind) { return map[kind]; }
        public static List<string> keys { get { return map.Keys.OrderBy((kind) => kind).ToList(); } }
    }

    public class StrategyRunMarathon:StrategyRun
    {
        public string execute() { return "Marathoning"; }
        public override string ToString() { return "Marathon"; }
    }
    public class StrategyRunSprint:StrategyRun
    {
        public string execute() { return "Sprinting"; }
        public override string ToString() { return "Sprint"; }
    }
}
