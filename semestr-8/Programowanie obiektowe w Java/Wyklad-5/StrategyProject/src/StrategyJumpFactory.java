
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;


public abstract class StrategyJumpFactory {
    
    
    private static final HashMap<String, StrategyJump> map = new HashMap<String, StrategyJump>()
    {
        {
            put("Long", new StrategyJumpLong());
            put("High", new StrategyJumpHigh());
            put("Pole", new StrategyJumpPole());
        }
    };
    
    public static final List<String> keys= map.keySet().stream().sorted().collect(Collectors.toList());
    public static StrategyJump get(String key) { return map.get(key); }
    
}
