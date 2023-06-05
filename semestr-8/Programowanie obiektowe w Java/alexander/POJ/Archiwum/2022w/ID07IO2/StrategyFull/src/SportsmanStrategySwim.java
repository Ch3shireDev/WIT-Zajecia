
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class SportsmanStrategySwim {
    
    private static final HashMap<String, SportsmanStrategySwim> map = new HashMap<String, SportsmanStrategySwim>()
    {
        {
            put("Crowl", new SportsmanStrategySwimCrowl());
            put("Frog", new SportsmanStrategySwimFrog());
            put("Butterfly", new SportsmanStrategySwimButterfly());
        }
    };
    public static final List<String> keys = map.keySet().stream().sorted().collect(Collectors.toList());
    public static SportsmanStrategySwim make (String kind)
    {
        return map.get(kind);
    }
           
    public abstract String execute();
    
}
