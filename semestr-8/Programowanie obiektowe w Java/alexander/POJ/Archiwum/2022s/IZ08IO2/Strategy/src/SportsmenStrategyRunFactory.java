
import java.util.List;
import java.util.ArrayList;
import java.util.stream.Collectors;
import java.util.Comparator;

public abstract class SportsmenStrategyRunFactory
{
   public static final List<SportsmenStrategyRun> strategies
   =
      (
         new ArrayList<SportsmenStrategyRun>()
         {
            {
               add(new SportsmenStrategyRunHurdles());
               add(new SportsmenStrategyRunMarthon());
               add(new SportsmenStrategyRunSprint());
            }
         }
      )
      .stream()
      .sorted((a,b) -> a.toString().compareTo(b.toString()))
      //.sorted(Comparator.comparing(SportsmenStrategyRun::toString))
      .collect(Collectors.toList())
   ;
}
