
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;


public abstract class StrategySwimFactory {
    
    
    private static final HashMap<String, StrategySwim> map = new HashMap<String, StrategySwim>()
    {
        {
            put("Butterfly", new StrategySwimButterfly());
            put("Craul", new StrategySwimCraul());
            put("Frog", new StrategySwimFrog());
        }
    };
    
    public static final List<String> keys= map.keySet().stream().sorted().collect(Collectors.toList());
    public static StrategySwim get(String key) { return map.get(key); }
    
}
