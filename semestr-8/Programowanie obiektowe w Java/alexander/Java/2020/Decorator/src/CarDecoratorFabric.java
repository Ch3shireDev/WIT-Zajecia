
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class CarDecoratorFabric 
{
   private final static HashMap<String,CarDecoratorMaker> map=new HashMap<String, CarDecoratorMaker>()
   {
      { // statyuczny konstruktor
         put("Tinted Window",(car) -> new TintedWindow(car));
         put("Leather Seat",(car) -> new LeatherSeat(car));
         put("Air Condition",(car) -> new AirCondition(car));
         put("Winter Tire",(car) -> new WinterTire(car));
      }
      //@Override public String toString() { return "Internal fabric map"; }      
   };
   public static Car make(String kind,Car car) // tworzymy dekorator, o wskazanym dodatku i nakladamy na wskazany samochód
   {
      //String str=map.toString();
      return map.get(kind).make(car);
   }
   public static List<String> keys() // zwracamy posortowane klucze z mapy
   {
      return map.keySet().stream().sorted().collect(Collectors.toList());
   }
}
