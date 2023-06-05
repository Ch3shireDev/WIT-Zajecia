
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class StrategyRunFactory
{
   private static HashMap<String,SportsmenStrategyRun> map=new HashMap<String, SportsmenStrategyRun>()
   {
      {
         put("Maraton",new SportsmenStrategyRunMaraton());
         put("Sprint",new SportsmenStrategyRunSprint());
      }
   };
   public static List<String> keys()
   {
      return map.keySet().stream().sorted().collect(Collectors.toList());
   }
   public static SportsmenStrategyRun make(String kind)
   {
      return map.get(kind);
   }
}
