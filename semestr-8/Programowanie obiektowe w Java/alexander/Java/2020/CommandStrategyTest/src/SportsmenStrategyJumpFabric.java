import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public class SportsmenStrategyJumpFabric
{
   private static HashMap<String,SportsmenStrategyJump> map = new HashMap<String,SportsmenStrategyJump>()
   {
      {
         put("High",new SportsmenStrategyJumpHigh());
         put("Long",new SportsmenStrategyJumpLong());
         put("Pole",new SportsmenStrategyJumpPole());
      }
   };
   public static List<String> keys()
   {
      return map.keySet().stream().sorted().collect(Collectors.toList());
   }
   public static SportsmenStrategyJump make(String kind)
   {
      return map.get(kind);
   }
}
