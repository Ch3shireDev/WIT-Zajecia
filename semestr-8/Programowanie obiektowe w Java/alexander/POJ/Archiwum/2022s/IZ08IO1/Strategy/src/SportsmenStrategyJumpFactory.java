
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class SportsmenStrategyJumpFactory
{
   private static final HashMap<String,SportsmenStrategyJump> map=new HashMap<String,SportsmenStrategyJump>()
   {
      {
         put("High",new SportsmenStrategyJumpHigh());
         put("Long",new SportsmenStrategyJumpLong());
         put("Pole",new SportsmenStrategyJumpPole());
      }
   };
   public static final List<String> keys=map.keySet().stream().sorted().collect(Collectors.toList());
   public static SportsmenStrategyJump get(String name) { return map.get(name); }
}
