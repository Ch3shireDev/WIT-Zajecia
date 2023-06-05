
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class CarDecorator extends Car
{
   private static HashMap<String,CarDecoratorMaker> map=new HashMap<String,CarDecoratorMaker>()
   {
      {
         put("Air Condition",(car)->new AirCondition(car));
         put("Tinted Window",(car)->new TintedWindow(car));
         put("Winter Tire",(car)->new WinterTire(car));
         put("Leather Seats",(car)->new LeatherSeats(car));
      }
   };
   public static final List<String> keys=map.keySet().stream().sorted().collect(Collectors.toList());
   public static Car make(String kind,Car car) { return map.get(kind).make(car); }
   private Car car;
   public CarDecorator(Car car) { this.car=car; }
   @Override public String info() { return car.info(); }
   @Override public int price() { return car.price(); }
}

interface CarDecoratorMaker
{
   Car make(Car car);
}