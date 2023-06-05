package calculator;

import java.util.HashMap;

public class Operations 
{
   private static HashMap<String,OperatorInterface> map=create();
   private static HashMap<String,OperatorInterface> create()
   {
      HashMap<String,OperatorInterface> map=new HashMap<>();
      map.put("+", new OperatorInterface() { @Override public double calc(double a,double b) { return a+b; } });
      map.put("-", new OperatorInterface() { @Override public double calc(double a,double b) { return a-b; } });
      map.put("*", new OperatorInterface() { @Override public double calc(double a,double b) { return a*b; } });
      map.put("/", new OperatorInterface() { @Override public double calc(double a,double b) { return a/b; } });
      return map;
   }
   private static OperatorInterface find(String op)
   {
      return map.get(op);
   }
   public static double calc(double a,String op,double b)
   {
      return find(op).calc(a,b);
   }
}
