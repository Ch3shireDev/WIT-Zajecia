

import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public class OperationFactory
{
    private static interface Calculate
    {
        public double calculate(double a,double b);
    }
    private static final HashMap<String,Calculate> map=new HashMap<String,Calculate>()
    {
        {
            put("+",(a,b) -> a+b);
            put("-",(a,b) -> a-b);
            put("*",(a,b) -> a*b);
            put("/",(a,b) -> a/b);
        }
    };
    public static final List<String> keys=map.keySet().stream().sorted().collect(Collectors.toList());
    public static double calculate(double a,double b,String op)
    {
        return map.get(op).calculate(a,b);
    }
}
