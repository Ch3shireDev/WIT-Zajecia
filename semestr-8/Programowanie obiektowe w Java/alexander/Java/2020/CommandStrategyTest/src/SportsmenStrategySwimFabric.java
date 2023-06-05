import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public class SportsmenStrategySwimFabric
{
   private static HashMap<String,SportsmenStrategySwim> map = new HashMap<String,SportsmenStrategySwim>()
   {
      {
         put("Frog",new SportsmenStrategySwimFrog());
         put("Butterfly",new SportsmenStrategySwimButterfly());
         put("Crawl",new SportsmenStrategySwimCrawl());
      }
   };
   public static List<String> keys()
   {
      return map.keySet().stream().sorted().collect(Collectors.toList());
   }
   public static SportsmenStrategySwim make(String kind)
   {
      return map.get(kind);
   }
}
