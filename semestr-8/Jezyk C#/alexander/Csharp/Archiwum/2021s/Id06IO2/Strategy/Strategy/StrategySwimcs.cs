using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface StrategySwim
    {
        string execute();
    }
    public abstract class StrategySwimFabric
    {
        private static Dictionary<String, StrategySwim> map = new Dictionary<string, StrategySwim>()
        {
            {"Crawl",new StrategySwimCrawl()},
            {"Butterfly",new StrategySwimButterfly()},
        };
        public static List<String> keys
        {
            get { return map.Keys.OrderBy((kind) => kind).ToList(); }
        }
        public static StrategySwim make(string kind) { return map[kind]; }
    }
    public class StrategySwimCrawl:StrategySwim
    {
        public string execute() { return "Crawling"; }
        public override string ToString() { return "Crawl"; }
    }
    public class StrategySwimButterfly : StrategySwim
    {
        public string execute() { return "Butterflying"; }
        public override string ToString() { return "Butterfly"; }
    }
}
