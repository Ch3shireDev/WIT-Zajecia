package fraction;

import java.util.Scanner;

public class FractionTest 
{
   private static Scanner sc=new Scanner(System.in);
   public static void main(String[] args) 
   {
      while(true)
      {
         System.out.print("Podaj wyrażenie ułamkowe: ");
         /*
         long an=sc.nextLong();
         String as=sc.next("\\s/\\s");
         long ad=sc.nextLong();
         String op=sc.next("\\s[\\+\\-\\*\\/]\\s");
         long bn=sc.nextLong();
         String bs=sc.next("\\s/\\s");
         long bd=sc.nextLong();
         */
         long an=sc.nextLong();
         String as=sc.next();
         long ad=sc.nextLong();
         String op=sc.next();
         long bn=sc.nextLong();
         String bs=sc.next();
         long bd=sc.nextLong();
         
         Fraction a=new Fraction(an,ad);
         Fraction b=new Fraction(bn,bd);
         Fraction c=FractionOperation.operation(op).execute(a, b);
         System.out.println(String.format("%s %s %s = %s", a,op,b,c));
      }
   }   
}
