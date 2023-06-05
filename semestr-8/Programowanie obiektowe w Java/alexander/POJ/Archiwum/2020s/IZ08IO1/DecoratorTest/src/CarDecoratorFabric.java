
import java.util.HashMap;
import java.util.List;
import java.util.Comparator;
import java.util.stream.Collectors;

public class CarDecoratorFabric
{
    private static final HashMap<String,CarDecoratorMaker> map=new HashMap<String,CarDecoratorMaker>()
    {
        {
            put("Tinted Window",(car)->new TintedWindow(car));
            put("Winter Tire",(car)->new WinterTire(car));
            put("Leather Sits",(car)->new LeatherSits(car));
            put("Air Condition",(car)->new AirCondition(car));
        }
    };
    public static Car make(String model,Car car) { return map.get(model).make(car); }
    public static List<String> models()
    {
        return map.keySet().stream().sorted(Comparator.naturalOrder()).collect(Collectors.toList());
    }
}

interface CarDecoratorMaker
{
    CarDecorator make(Car car);
}

class CarDecorator extends Car
{
    private final Car car;
    public CarDecorator(Car car) { this.car=car; }
    @Override public String info() { return car.info(); }
    @Override public long price() { return car.price(); }
}

class TintedWindow extends CarDecorator
{
    public TintedWindow(Car car) { super(car); }
    @Override public String info() { return super.info()+" + Tinted Window"; }
    @Override public long price() { return super.price()+3000; }
}

class WinterTire extends CarDecorator
{
    public WinterTire(Car car) { super(car); }
    @Override public String info() { return super.info()+" + Winter Tire"; }
    @Override public long price() { return super.price()+3000; }
}

class LeatherSits extends CarDecorator
{
    public LeatherSits(Car car) { super(car); }
    @Override public String info() { return super.info()+" + Leather Sits"; }
    @Override public long price() { return super.price()+3000; }
}

class AirCondition extends CarDecorator
{
    public AirCondition(Car car) { super(car); }
    @Override public String info() { return super.info()+" + Air Condition"; }
    @Override public long price() { return super.price()+3000; }
}