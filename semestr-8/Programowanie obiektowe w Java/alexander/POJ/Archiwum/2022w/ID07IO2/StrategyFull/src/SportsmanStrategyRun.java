
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class SportsmanStrategyRun {
    
    private static final HashMap<String, SportsmanStrategyRun> map = new HashMap<String, SportsmanStrategyRun>()
    {
        {
            put("Marathon", new SportsmanStrategyRunMarathon());
            put("Sprint", new SportsmanStrategyRunSprint());
            put("Kilometer", new SportsmanStrategyRunKilometer());
        }
    };
    public static final List<String> keys = map.keySet().stream().sorted().collect(Collectors.toList());
    public static SportsmanStrategyRun make (String kind)
    {
        return map.get(kind);
    }
           
    public abstract String execute();
    
}
