import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class StrategyJumpFabric
{
   private static final HashMap<String,StrategyJump> map=new HashMap<String,StrategyJump>()
   {
      {
         put("Jump High",new StrategyHigh());
         put("Jump Long",new StrategyLong());
         put("Jump Hurdle",new StrategyHurdle());
      }
   };
   public static List<String> Keys()
   {
      return map.keySet().stream().sorted().collect(Collectors.toList());
   }
   public static StrategyJump Make(String kind)
   {
      return map.get(kind);
   }
}

interface StrategyJump extends StrategyBase {}

class StrategyHigh implements StrategyJump
{
   @Override public String execute() { return "High"; }
}

class StrategyLong implements StrategyJump
{
   @Override public String execute() { return "Long"; }
}

class StrategyHurdle implements StrategyJump
{
   @Override public String execute() { return "Hurdle"; }
}