
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class SportsmanStrategyJump {
    
    private static final HashMap<String, SportsmanStrategyJump> map = new HashMap<String, SportsmanStrategyJump>()
    {
        {
            put("High", new SportsmanStrategyJumpHigh());
            put("Long", new SportsmanStrategyJumpLong());
            put("Pole Vault", new SportsmanStrategyJumpPoleVault());
        }
    };
    public static final List<String> keys = map.keySet().stream().sorted().collect(Collectors.toList());
    public static SportsmanStrategyJump make (String kind)
    {
        return map.get(kind);
    }
           
    public abstract String execute();
    
}
