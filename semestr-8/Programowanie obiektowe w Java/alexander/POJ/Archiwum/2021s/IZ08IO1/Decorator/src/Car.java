
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class Car
{
   private static HashMap<String,CarMaker> map=new HashMap<String,CarMaker>()
   {
      {
         put("Mercedes",()->new Mercedes());
         put("Peugeot",()->new Peugeot());
         put("Opel",()->new Opel());
         put("Renault",()->new Renault());
      }
   };
   public static final List<String> keys=map.keySet().stream().sorted().collect(Collectors.toList());
   public static Car make(String kind) { return map.get(kind).make(); }
   public abstract String info();
   public abstract int price();
   @Override public String toString()
   {
      return String.format("%7d\t%s",price(),info());
   }
}

interface CarMaker
{
   Car make();
}