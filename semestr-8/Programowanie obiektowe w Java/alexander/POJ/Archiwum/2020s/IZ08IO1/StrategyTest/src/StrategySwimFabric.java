import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class StrategySwimFabric
{
   private static final HashMap<String,StrategySwim> map=new HashMap<String,StrategySwim>()
   {
      {
         put("Swim Crawl",new StrategyCrawl());
         put("Swim Butterfly",new StrategyButterfly());
         put("Swim Frog",new StrategyFrog());
      }
   };
   public static List<String> Keys()
   {
      return map.keySet().stream().sorted().collect(Collectors.toList());
   }
   public static StrategySwim Make(String kind)
   {
      return map.get(kind);
   }
}

interface StrategySwim extends StrategyBase {}

class StrategyCrawl implements StrategySwim
{
   @Override public String execute() { return "Crawl"; }
}

class StrategyButterfly implements StrategySwim
{
   @Override public String execute() { return "Butterfly"; }
}

class StrategyFrog implements StrategySwim
{
   @Override public String execute() { return "Frog"; }
}