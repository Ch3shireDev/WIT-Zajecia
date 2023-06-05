
import java.util.Comparator;
import java.util.List;
import java.util.HashMap;
import java.util.stream.Collectors;

public abstract class OperationFactory
{
    private static interface Calculate
    {
        public double calc(double a,double b);
    }
    private static HashMap<OperationKind,Calculate> map=new HashMap<OperationKind,Calculate>()
    {
        {
            put(OperationKind.OpAdd,(a,b)->a+b);
            put(OperationKind.OpSub,(a,b)->a-b);
            put(OperationKind.OpMul,(a,b)->a*b);
            put(OperationKind.OpDiv,(a,b)->a/b);
            put(OperationKind.OpPow,(a,b)->Math.pow(a,b));
        }
    };
    private static class EnumCodeComparator implements Comparator<OperationKind>
    {
        public int compare(OperationKind k1, OperationKind k2)
        {
            return k1.toString().compareTo(k2.toString());
        }
    }
    private static class EnumCodeComparatorDesc implements Comparator<OperationKind>
    {
        public int compare(OperationKind k1, OperationKind k2)
        {
            return k2.toString().compareTo(k1.toString());
        }
    }
    public static List<OperationKind> keys=map.keySet().stream().sorted(new EnumCodeComparator()).collect(Collectors.toList());
    public static double calc(OperationKind kind,double a,double b)
    {
        return map.get(kind).calc(a,b);
    }
}
