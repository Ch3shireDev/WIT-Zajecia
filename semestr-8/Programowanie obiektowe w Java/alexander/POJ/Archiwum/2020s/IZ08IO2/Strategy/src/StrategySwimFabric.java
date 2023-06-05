import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public class StrategySwimFabric 
{
   private final static HashMap<String,StrategySwim> map=new HashMap<String,StrategySwim>()
   {
      {
         put("Crawl",new StrategyCrawl());
         put("Butterfly",new StrategyButterfly());
         put("Frog",new StrategyFrog());
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

class StrategyCrawl implements StrategySwim
{
   @Override public String execute() { return "Swim Crawl"; }
}

class StrategyButterfly implements StrategySwim
{
   @Override public String execute() { return "Swim Butterfly"; }
}

class StrategyFrog implements StrategySwim
{
   @Override public String execute() { return "Swim Frog"; }
}