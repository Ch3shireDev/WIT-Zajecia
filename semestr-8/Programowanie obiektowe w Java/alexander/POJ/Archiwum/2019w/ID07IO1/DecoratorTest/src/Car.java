
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;

public class Car 
{
    private interface CarMaker { Car make(); }
    private final static HashMap<String,CarMaker> carmap=new HashMap<String,CarMaker>()
    {
        {
            put("Bar",() -> new Car());
            put("Var",() -> new Car());
            put("Car",() -> new Car());
        }
    };
    private interface DecorMaker { Car make(Car car); }
    private final static HashMap<String,DecorMaker> decormap=new HashMap<String,DecorMaker>()
    {
        {
            put("Aaaa",(car) -> new Car());
            put("Bbbb",(car) -> new Car());
            put("Cccc",(car) -> new Car());
        }
    };
    //*///
    public static ArrayList<String> carKeys()
    {
        final ArrayList<String> list=new ArrayList<>(carmap.keySet());
        list.sort((a,b) -> a.compareTo(b));
        return list;
    }
    /*/
    public static String[] keys()
    {
        final String[] list=new String[map.size()];
        map.keySet().toArray(list);
        Arrays.sort(list);
        return list;
    }
    //*///
    public static ArrayList<String> decorKeys()
    {
        final ArrayList<String> list=new ArrayList<>(decormap.keySet());
        list.sort((a,b) -> a.compareTo(b));
        return list;
    }
}
