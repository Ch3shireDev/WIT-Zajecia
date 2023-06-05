import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class CarFactory
{
    private static interface CarMaker { public Car make(); }
    private static final HashMap<String,CarMaker> factory=new HashMap<String,CarMaker>()
    {
        {
            put("Audi",() -> new Audi());
            put("Volvo",() -> new Volvo());
            put("Toyota",() -> new Toyota());
            put("Seat",() -> new Seat());
        }
    };
    public static final List<String> models=factory.keySet().stream().sorted().collect(Collectors.toList());
    public static Car make(String model) { return factory.get(model).make(); }
}
