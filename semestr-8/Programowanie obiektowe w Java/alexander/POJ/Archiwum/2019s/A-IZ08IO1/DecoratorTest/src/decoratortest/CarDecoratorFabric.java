package decoratortest;

import java.util.ArrayList;
import java.util.HashMap;

public class CarDecoratorFabric
{
   private static interface Maker { Car make(Car car); }
   private static HashMap<String,Maker> map=new HashMap<String,Maker>()
   {
      {
         put("Climatisation",(car)->new CarDecoratorClimatisation(car));
         put("Leather seats",(car)->new CarDecoratorLeatherSeats(car));
         put("Tinted window",(car)->new CarDecoratorTintedWindow(car));
         put("Winter tire",(car)->new CarDecoratorWinterTire(car));
      }
   };
   public static Car Make(Car car,String name) { return map.get(name).make(car); }
   public static String[] Keys()
   {
      ArrayList<String> ar=new ArrayList<>(map.keySet());
      ar.sort((a,b) -> a.compareTo(b));
      return ar.toArray(new String[0]);
   }
}
