import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public class SportsmenStrategyRunFabric // Fabrika strategii biegu
{
   // kolekcja strategii biegu skojarzone z nazwami
   private static HashMap<String,SportsmenStrategyRun> map = new HashMap<String,SportsmenStrategyRun>()
   {
      {
         put("Sprint",new SportsmenStrategyRunSprint());
         put("Maraton",new SportsmenStrategyRunMaraton());
         put("Kilometer",new SportsmenStrategyRunKilometer());
      }
   };
   public static List<String> keys() // posortowana lista nazw strategii biegu
   {
      return map.keySet().stream().sorted().collect(Collectors.toList());
   }
   public static SportsmenStrategyRun make(String kind) // pobieranie strategii biegu wg nazwy
   {
      return map.get(kind);
   }
}
