
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class OperationFactory {
    private static final HashMap<String, OperationInterface> factory = new HashMap<String, OperationInterface>() {
        {
            put("+", (a,b) -> a + b);
            put("-", (a,b) -> a - b);
            put("*", (a,b) -> a * b);
            put("/", (a,b) -> a / b);
            put("^", (a,b) -> Math.pow(a, b));
        }  
    };
    
    public static final List<String> keys = factory
        .keySet()
        .stream()
        .sorted()
        .collect(Collectors.toList()); 
    
    public static double Calculate(double a, String operation, double b) {
        return factory.get(operation).Calculate(a,b);
    }
}
