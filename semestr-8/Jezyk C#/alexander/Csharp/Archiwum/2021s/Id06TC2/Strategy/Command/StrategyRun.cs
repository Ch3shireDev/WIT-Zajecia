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
        private static Dictionary<string,StrategyRun> map = new Dictionary<string, StrategyRun>()
        {
            {"Maratron",new StrategyRunMaraton()},
            {"Sprint",new StrategyRunSprint()},
        };
        public static StrategyRun get(string strategy) { return map[strategy]; }
        public static List<string> keys { get { return map.Keys.OrderBy((strategy)=>strategy).ToList(); } }
    }
    public class StrategyRunMaraton:StrategyRun
    {
        public string execute() { return "Maratoning"; }
    }
    public class StrategyRunSprint:StrategyRun
    {
        public string execute() { return "Sprinting"; }
    }
}
