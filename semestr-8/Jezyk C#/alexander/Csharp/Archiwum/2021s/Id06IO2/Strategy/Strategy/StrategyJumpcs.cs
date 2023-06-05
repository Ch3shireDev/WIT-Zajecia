using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface StrategyJump
    {
        string execute();
    }
    public abstract class StrategyJumpFabric
    {
        private static Dictionary<String,StrategyJump> map = new Dictionary<string,StrategyJump>()
        {
            {"Long",new StrategyJumpLong()},
            {"High",new StrategyJumpHigh()},
        };
        public static List<String> keys
        {
            get { return map.Keys.OrderBy((kind) => kind).ToList(); }
        }
        public static StrategyJump make(string kind) { return map[kind]; }
    }
    public class StrategyJumpLong:StrategyJump
    {
        public string execute() { return "Long jumping"; }
        public override string ToString() { return "Long jump"; }
    }
    public class StrategyJumpHigh:StrategyJump
    {
        public string execute() { return "High jumping"; }
        public override string ToString() { return "High jump"; }
    }
}
