import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class StrategyRunFabric
{
   private static final HashMap<String,StrategyRun> map=new HashMap<String,StrategyRun>()
   {
      {
         put("Run Maraton",new StrategyMaraton());
         put("Run Sprint",new StrategySprint());
         put("Run Kilometer",new StrategyKilometer());
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

interface StrategyRun extends StrategyBase {}

class StrategyMaraton implements StrategyRun
{
   @Override public String execute() { return "Maraton"; }
}

class StrategySprint implements StrategyRun
{
   @Override public String execute() { return "Sprint"; }
}

class StrategyKilometer implements StrategyRun
{
   @Override public String execute() { return "Kilometer"; }
}