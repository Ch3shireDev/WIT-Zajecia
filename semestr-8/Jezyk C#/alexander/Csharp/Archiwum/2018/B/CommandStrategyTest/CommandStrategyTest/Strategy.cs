using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandStrategyTest
{
    interface Strategy
    {
        string execute();
    }
    interface StrategyRun: Strategy
    {
    }
    interface StrategyJump : Strategy
    {
    }
    interface StrategySwim : Strategy
    {
    }
    class Maraton: StrategyRun
    {
        public string execute() { return "Maraton"; }
    }
    class Sprint : StrategyRun
    {
        public string execute() { return "Sprint"; }
    }
    class MediumDistance : StrategyRun
    {
        public string execute() { return "MediumDistance"; }
    }
    class LongJump : StrategyJump
    {
        public string execute() { return "LongJump"; }
    }
    class HighJump : StrategyJump
    {
        public string execute() { return "HighJump"; }
    }
    class Railings : StrategyJump
    {
        public string execute() { return "Railings"; }
    }
    class Crawl : StrategySwim
    {
        public string execute() { return "Crawl"; }
    }
    class Frog : StrategySwim
    {
        public string execute() { return "Frog"; }
    }
    class Butterfly : StrategySwim
    {
        public string execute() { return "Butterfly"; }
    }
    delegate StrategyRun MakeStrategyRun();
    class StrategyRunList
    {
        private static Dictionary<string, MakeStrategyRun> map=new Dictionary<string, MakeStrategyRun>()
        {
            { "Maraton", () => new Maraton() },
            { "Sprint", () => new Sprint() },
            { "MediumDistance", () => new MediumDistance() },
        };
        public static string[] names()
        {
            List<string> lst = map.Keys.ToList();
            lst.Sort();
            return lst.ToArray();
        }
        public static StrategyRun make(string key) { return map[key](); }
    }
    delegate StrategyJump MakeStrategyJump();
    class StrategyJumpList
    {
        private static Dictionary<string, MakeStrategyJump> map = new Dictionary<string, MakeStrategyJump>()
        {
            { "LongJump", () => new LongJump() },
            { "HighJump", () => new HighJump() },
            { "Railings", () => new Railings() },
        };
        public static string[] names()
        {
            List<string> lst = map.Keys.ToList();
            lst.Sort();
            return lst.ToArray();
        }
        public static StrategyJump make(string key) { return map[key](); }
    }
    delegate StrategySwim MakeStrategySwim();
    class StrategySwimList
    {
        private static Dictionary<string, MakeStrategySwim> map = new Dictionary<string, MakeStrategySwim>()
        {
            { "Crawl", () => new Crawl() },
            { "Frog", () => new Frog() },
            { "Butterfly", () => new Butterfly() },
        };
        public static string[] names()
        {
            List<string> lst = map.Keys.ToList();
            lst.Sort();
            return lst.ToArray();
        }
        public static StrategySwim make(string key) { return map[key](); }
    }
}
