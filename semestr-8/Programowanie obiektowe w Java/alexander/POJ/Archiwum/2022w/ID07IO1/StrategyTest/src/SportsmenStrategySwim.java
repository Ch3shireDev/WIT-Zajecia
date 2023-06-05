
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class SportsmenStrategySwim implements SportsmenStrategy
{
   private static final HashMap<String,SportsmenStrategySwim> map=new HashMap<String,SportsmenStrategySwim>()
   {
      {
         put("Crowl",new SportsmenStrategySwimCrowl());
         put("Batterfly",new SportsmenStrategySwimBatterfly());
         put("Frog",new SportsmenStrategySwimFrog());
      }
   };
   private static final List<String> list=map.keySet().stream().sorted().collect(Collectors.toList());
   public static List<String> keys() { return list; }
   public static SportsmenStrategySwim make(String kind) { return map.get(kind); }
}
