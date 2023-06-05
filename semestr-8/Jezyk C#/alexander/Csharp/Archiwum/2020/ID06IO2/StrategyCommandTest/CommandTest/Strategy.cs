using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandTest
{
    interface StrategyBase { string execute(); }
    interface StrategyRun : StrategyBase {}
    interface StrategyJump : StrategyBase {}
    interface StrategySwim : StrategyBase {}

    class StrategyRunFabric
    {
        private static Dictionary<string, StrategyRun> map = new Dictionary<string, StrategyRun>()
        {
            {"Maraton", new StrategyMaraton()},
            {"Sprint", new StrategySprint()},
            {"Kilometr", new StrategyKilometr()},
        };
        public static string[] Keys() { return map.Keys.OrderBy(s => s).ToArray(); }
        public static StrategyRun Get(string kind) { return map[kind]; }
    }

    class StrategyMaraton : StrategyRun
    {
        public string execute() { return "Run Maraton"; }
    }
    class StrategySprint : StrategyRun
    {
        public string execute() { return "Run Sprint"; }
    }
    class StrategyKilometr : StrategyRun
    {
        public string execute() { return "Run Kilometr"; }
    }

    class StrategyJumpFabric
    {
        private static Dictionary<string, StrategyJump> map = new Dictionary<string, StrategyJump>()
        {
            {"High", new StrategyHigh()},
            {"Long", new StrategyLong()},
            {"Pole", new StrategyPole()},
        };
        public static string[] Keys() { return map.Keys.OrderBy(s => s).ToArray(); }
        public static StrategyJump Get(string kind) { return map[kind]; }
    }

    class StrategyHigh : StrategyJump
    {
        public string execute() { return "Jump High"; }
    }
    class StrategyLong : StrategyJump
    {
        public string execute() { return "Jump Long"; }
    }
    class StrategyPole : StrategyJump
    {
        public string execute() { return "Jump Pole"; }
    }

    class StrategySwimFabric
    {
        private static Dictionary<string, StrategySwim> map = new Dictionary<string, StrategySwim>()
        {
            {"Crawl", new StrategyCrawl()},
            {"Butterfly", new StrategyButterfly()},
            {"Frog", new StrategyFrog()},
        };
        public static string[] Keys() { return map.Keys.OrderBy(s => s).ToArray(); }
        public static StrategySwim Get(string kind) { return map[kind]; }
    }

    class StrategyCrawl : StrategySwim
    {
        public string execute() { return "Swim Crawl"; }
    }
    class StrategyButterfly : StrategySwim
    {
        public string execute() { return "Swim Butterfly"; }
    }
    class StrategyFrog : StrategySwim
    {
        public string execute() { return "Swim Frog"; }
    }
}
