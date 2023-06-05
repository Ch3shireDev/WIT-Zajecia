using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandTest
{
    interface StrategyBase { string execute(); }
    interface StrategyRun : StrategyBase { }
    interface StrategyJump : StrategyBase { }
    interface StrategySwim : StrategyBase { }
    class StrategyRunFabric
    {
        private static Dictionary<string, StrategyRun> map = new Dictionary<string, StrategyRun>()
        {
            {"Marathon", new StrategyMarathon()},
            {"Sprint", new StrategySprint()},
            {"Kilometer", new StrategyKilometer()},
        };
        public static string[] Keys { get { return map.Keys.OrderBy(s => s).ToArray(); } }
        public static StrategyRun Get(string key) { return map[key]; }
    }
    class StrategyMarathon : StrategyRun { public string execute() { return "Run Marathon"; } }
    class StrategySprint : StrategyRun { public string execute() { return "Run Sprint"; } }
    class StrategyKilometer : StrategyRun { public string execute() { return "Run Kilometer"; } }
    class StrategyJumpFabric
    {
        private static Dictionary<string, StrategyJump> map = new Dictionary<string, StrategyJump>()
        {
            {"Long", new StrategyLong()},
            {"High", new StrategyHigh()},
            {"Pole", new StrategyPole()},
        };
        public static string[] Keys { get { return map.Keys.OrderBy(s => s).ToArray(); } }
        public static StrategyJump Get(string key) { return map[key]; }
    }
    class StrategyLong : StrategyJump { public string execute() { return "Jump Long"; } }
    class StrategyHigh : StrategyJump { public string execute() { return "Jump High"; } }
    class StrategyPole : StrategyJump { public string execute() { return "Jump Pole"; } }
    class StrategySwimFabric
    {
        private static Dictionary<string, StrategySwim> map = new Dictionary<string, StrategySwim>()
        {
            {"Butterfly", new StrategyButterfly()},
            {"Crawl", new StrategyCrawl()},
            {"Frog", new StrategyFrog()},
        };
        public static string[] Keys { get { return map.Keys.OrderBy(s => s).ToArray(); } }
        public static StrategySwim Get(string key) { return map[key]; }
    }
    class StrategyButterfly : StrategySwim { public string execute() { return "Swim Butterfly"; } }
    class StrategyCrawl : StrategySwim { public string execute() { return "Swim Crawl"; } }
    class StrategyFrog : StrategySwim { public string execute() { return "Swim Frog"; } }
}
