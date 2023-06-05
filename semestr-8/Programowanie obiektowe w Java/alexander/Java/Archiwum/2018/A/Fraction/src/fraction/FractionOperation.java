package fraction;

import java.util.HashMap;

public interface FractionOperation 
{
   public Fraction execute(Fraction a,Fraction b);
   public static final HashMap<String,FractionOperation> map=make();
   public static HashMap<String,FractionOperation> make()
   {
      HashMap<String,FractionOperation> map=new HashMap<>();
      map.put
      (
         "+",
         new FractionOperation()
         {
            public @Override Fraction execute(Fraction a,Fraction b)
            {
               return Fraction.add(a, b);
            }
         }
      );
      map.put("-", (FractionOperation) (Fraction a, Fraction b) -> Fraction.sub(a, b));
      map.put("*", (Fraction a, Fraction b) -> Fraction.mul(a, b));
      map.put("/", (Fraction a, Fraction b) -> Fraction.div(a, b));
      return map;
   }
   
   /*
   public static final HashMap<String,FractionOperation> map=new HashMap<>();
   static
   {
         map.put("-",(FractionOperation)(Fraction a, Fraction b) -> Fraction.add(a, b));
         map.put("-",(FractionOperation)(Fraction a, Fraction b) -> Fraction.sub(a, b));
         map.put("*",(FractionOperation)(Fraction a, Fraction b) -> Fraction.mul(a, b));
         map.put("/",(FractionOperation)(Fraction a, Fraction b) -> Fraction.div(a, b));
   }
   */
   
   public static FractionOperation operation(String key)
   {
      return map.get(key);
   }
}
