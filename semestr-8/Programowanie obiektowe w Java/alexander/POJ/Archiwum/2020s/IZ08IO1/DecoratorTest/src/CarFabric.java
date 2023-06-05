
import java.util.HashMap;
import java.util.List;
import java.util.Comparator;
import java.util.stream.Collectors;

public class CarFabric 
{
    private static final HashMap<String,CarMaker> map=new HashMap<String,CarMaker>()
    {
        {
            put("Volvo",()->new Volvo());
            put("Szkoda",()->new Szkoda());
            put("Peugeot",()->new Peugeot());
            put("Mercedes",()->new Mercedes());
        }
    };
    public static Car make(String model) { return map.get(model).make(); }
    public static List<String> models()
    {
        return map.keySet().stream().sorted(Comparator.naturalOrder()).collect(Collectors.toList());
    }
}

interface CarMaker
{
    Car make();
}

abstract class Car
{
    public abstract String info();
    public abstract long price();
    @Override public String toString() { return price()+"\t"+info(); }
}

class Volvo extends Car
{
    @Override public String info() { return "Volvo"; }
    @Override public long price() { return 50000; }
}

class Szkoda extends Car
{
    @Override public String info() { return "Szkoda"; }
    @Override public long price() { return 40000; }
}

class Peugeot extends Car
{
    @Override public String info() { return "Peugeot"; }
    @Override public long price() { return 80000; }
}

class Mercedes extends Car
{
    @Override public String info() { return "Mercedes"; }
    @Override public long price() { return 70000; }
}
