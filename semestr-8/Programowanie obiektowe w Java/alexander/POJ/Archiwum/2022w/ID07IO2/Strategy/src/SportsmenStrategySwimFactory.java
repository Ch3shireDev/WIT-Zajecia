
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class SportsmenStrategySwimFactory
{
   private static final HashMap<String,SportsmenStrategySwim> map=new HashMap<String,SportsmenStrategySwim>()
   {
      {
         put("Crowl",new SportsmenStrategySwimCrowl());
         put("Frog",new SportsmenStrategySwimFrog());
         put("Batterfly",new SportsmenStrategySwimBatterfly());
      }
   };
   public static final List<String> keys=map.keySet().stream().sorted().collect(Collectors.toList());
   public static SportsmenStrategySwim make(String kind) { return map.get(kind); }
}
