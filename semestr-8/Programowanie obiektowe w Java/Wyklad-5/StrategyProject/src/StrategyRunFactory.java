
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;


public abstract class StrategyRunFactory {

    private static final HashMap<String, StrategyRun> map = new HashMap<String, StrategyRun>()
    {
        {
            put("Marathon", new StrategyRunMarathon());
            put("Sprint", new StrategyRunSprint());
            put("Hurdle", new StrategyRunHurdle());
        }
    };
    
    public static final List<String> keys= map.keySet().stream().sorted().collect(Collectors.toList());
    public static StrategyRun get(String key) { return map.get(key); }
    
}
