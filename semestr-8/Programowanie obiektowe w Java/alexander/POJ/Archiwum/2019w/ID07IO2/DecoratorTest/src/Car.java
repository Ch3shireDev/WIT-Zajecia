
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.stream.Collectors;

public class Car 
{
    private interface CarMaker { Car make(Car car); }
    private final static HashMap<String,CarMaker> carmap=new HashMap<String,CarMaker>()
    {
        {
            put("Bar",(car) -> new Car());
            put("Var",(car) -> new Car());
            put("Car",(car) -> new Car());
        }
    };
    private final static HashMap<String,CarMaker> decormap=new HashMap<String,CarMaker>()
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
        final ArrayList<String> list=new ArrayList<String>(carmap.keySet());
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
        final ArrayList<String> list=new ArrayList<String>(decormap.keySet());
        list.sort((a,b) -> a.compareTo(b));
        return list;
    }
}
