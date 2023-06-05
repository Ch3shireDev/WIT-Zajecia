import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;

public class OperationFactory
{
    private static interface Operation { public double execute(double a,double b); }
    private static final Map<String,Operation> map=new HashMap<String,Operation>()
    {
        {
            put("+",(a,b) -> a+b);
            put("-",(a,b) -> a-b);
            put("*",(a,b) -> a*b);
            put("/",(a,b) -> a/b);
        }
    };
    public static final List<String> keys=map.keySet().stream().sorted().collect(Collectors.toList()); // 
    public static double execute(double a, String operation,double b)
    {
        return map.get(operation).execute(a,b);
    }
}
