import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public class CarDecoratorFabric 
{
    private static interface CarDecoratorMaker
    {
        Car make(Car car);
    }
    private static HashMap<String,CarDecoratorMaker> MAP=new HashMap<String,CarDecoratorMaker>()
    {
        {
            put("Leather Sits",(car)->new LeatherSits(car));
            put("Tinted Window",(car)->new TintedWindow(car));
            put("Air Condition",(car)->new AirCondition(car));
            put("Winter Tire",(car)->new WinterTire(car));
        }
    };
    public static List<String> names()
    {
        return MAP.keySet().stream().sorted().collect(Collectors.toList());
    }
    public static Car make(String kind,Car car)
    {
        return MAP.get(kind).make(car);
    }
}
