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
    public abstract class StrategyJumpFactory
    {
        private static Dictionary<string, StrategyJump> map = new Dictionary<string, StrategyJump>()
        {
            {"Long",new StrategyJumpLong()},
            {"High",new StrategyJumpHigh()},
        };
        public static StrategyJump make(string kind) { return map[kind]; }
        public static List<string> keys { get { return map.Keys.OrderBy((kind) => kind).ToList(); } }
    }

    public class StrategyJumpLong:StrategyJump
    {
        public string execute() { return "Long jumping"; }
        public override string ToString() { return "Long"; }
    }
    public class StrategyJumpHigh:StrategyJump
    {
        public string execute() { return "High jumping"; }
        public override string ToString() { return "High"; }
    }
}
