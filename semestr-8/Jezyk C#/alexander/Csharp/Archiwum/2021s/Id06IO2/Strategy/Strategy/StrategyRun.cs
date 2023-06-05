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
    public abstract class StrategyRunFabric
    {
        private static Dictionary<String,StrategyRun> map = new Dictionary<string,StrategyRun>()
        {
            {"Maraton",new StrategyRunMaraton()},
            {"Sprint",new StrategyRunSprint()},
        };
        public static List<String> keys
        {
            get { return map.Keys.OrderBy((kind) => kind).ToList(); }
        }
        public static StrategyRun make(string kind) { return map[kind]; }
    }
    public class StrategyRunMaraton:StrategyRun
    {
        public string execute() { return "Maratoning"; }
        public override string ToString() { return "Maraton"; }
    }
    public class StrategyRunSprint:StrategyRun
    {
        public string execute() { return "Sprinting"; }
        public override string ToString() { return "Sprint"; }
    }
}
