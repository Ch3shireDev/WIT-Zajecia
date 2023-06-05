
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public class CarFabric 
{
    private static interface CarMaker
    {
        Car make();
    }
    private static HashMap<String,CarMaker> MAP=new HashMap<String,CarMaker>()
    {
        {
            put("Peugeot",()->new Peugeot());
            put("Volvo",()->new Volvo());
            put("Mercedes",()->new Mercedes());
            put("Audi",()->new Audi());
            put("Kia",()->new Kia());
        }
    };
    public static List<String> names()
    {
        return MAP.keySet().stream().sorted().collect(Collectors.toList());
    }
    public static Car make(String kind)
    {
        return MAP.get(kind).make();
    }
}
