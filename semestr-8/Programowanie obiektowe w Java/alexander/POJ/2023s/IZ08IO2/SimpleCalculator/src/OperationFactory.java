import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;

public class OperationFactory
{
    private static interface Calculate
    {
        double calculate(double a,double b);
    }
    private static final Map<String,Calculate> map=new HashMap<String,Calculate>()
    {
        {
            put("+",(a,b) -> a+b);
            put("-",(a,b) -> a-b);
            put("*",(a,b) -> a*b);
            put("/",(a,b) -> a/b);
        }
    };
    public static List<String> keys=map.keySet().stream().sorted().collect(Collectors.toList());
    public static double calculate(double a,String operation,double b)
    {
        return map.get(operation).calculate(a,b);
    }
}
