package decoratortest;

import java.util.ArrayList;
import java.util.HashMap;

public class CarFabric
{
   private static interface Maker { Car make(); }
   private static HashMap<String,Maker> map=new HashMap<String,Maker>()
   {
      {
         put("Peugeot",()->new CarPeugeot());
         put("Mercedes",()->new CarMercedes());
         put("Volvo",()->new CarVolvo());
         put("Skoda",()->new CarSkoda());
      }
   };
   public static Car Make(String name) { return map.get(name).make(); }
   public static String[] Keys()
   {
      ArrayList<String> ar=new ArrayList<>(map.keySet());
      ar.sort((a,b) -> a.compareTo(b));
      return ar.toArray(new String[0]);
   }
}
