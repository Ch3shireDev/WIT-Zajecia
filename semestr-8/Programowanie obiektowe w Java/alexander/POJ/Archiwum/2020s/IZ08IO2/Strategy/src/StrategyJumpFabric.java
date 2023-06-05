import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public class StrategyJumpFabric 
{
   private final static HashMap<String,StrategyJump> map=new HashMap<String,StrategyJump>()
   {
      {
         put("Long",new StrategyLong());
         put("Short",new StrategyShort());
         put("Hurdle",new StrategyHurdle());
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

class StrategyLong implements StrategyJump
{
   @Override public String execute() { return "Jump Long"; }
}

class StrategyShort implements StrategyJump
{
   @Override public String execute() { return "Jump Short"; }
}

class StrategyHurdle implements StrategyJump
{
   @Override public String execute() { return "Jump Hurdle"; }
}