package fraction;

import java.util.HashMap;

public class FractionMap 
{
   private static final HashMap<String,FractionOperation> map=make();
   private static HashMap<String,FractionOperation> make()
   {
      HashMap<String,FractionOperation> map=new HashMap<>();
      map.put
      (
         "+",
         new FractionOperation() 
         {
            public @Override Fraction execute(Fraction a, Fraction b) 
            {
               return Fraction.add(a,b);
            }
         }
      );
      map.put("-",(Fraction a, Fraction b) -> Fraction.sub(a,b));
      map.put("*",(Fraction a, Fraction b) -> Fraction.mul(a,b));
      map.put("/",(Fraction a, Fraction b) -> Fraction.div(a,b));
      return map;
   }
   public static FractionOperation get(String op) { return map.get(op); }
}
