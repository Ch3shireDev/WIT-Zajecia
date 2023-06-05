import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public class StrategyRunFabric 
{
   private final static HashMap<String,StrategyRun> map=new HashMap<String,StrategyRun>()
   {
      {
         put("Maraton",new StrategyMaraton());
         put("Sprint",new StrategySprint());
         put("Kilometer",new StrategyKilometer());
      }
   };
   public static List<String> Keys()
   {
      return map.keySet().stream().sorted().collect(Collectors.toList());      
   }
   public static StrategyRun Make(String kind)
   {
      return map.get(kind);
   }
}

class StrategyMaraton implements StrategyRun
{
   @Override public String execute() { return "Run Maraton"; }
}

class StrategySprint implements StrategyRun
{
   @Override public String execute() { return "Run Sprint"; }
}

class StrategyKilometer implements StrategyRun
{
   @Override public String execute() { return "Run Kilometer"; }
}