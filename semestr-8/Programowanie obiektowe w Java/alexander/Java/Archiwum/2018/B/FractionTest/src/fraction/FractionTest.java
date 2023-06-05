package fraction;

import java.util.Scanner;

public class FractionTest 
{
   private static Scanner sc=new Scanner(System.in);
   public static void main(String[] args) 
   {
      while(true)
      {
         System.out.print("Input expresion: ");
         long an=sc.nextLong();
         String as=sc.next();
         long ad=sc.nextLong();
         String op=sc.next();
         long bn=sc.nextLong();
         String bs=sc.next();
         long bd=sc.nextLong();
         if((as.equals("/"))&&(bs.equals("/")))
         {
            Fraction a=new Fraction(an,ad);
            Fraction b=new Fraction(bn,bd);
            Fraction c=FractionMap.get(op).execute(a,b);
            System.out.println(String.format("%s %s %s = %s",a,op,b,c));
         }
         else System.out.println("Bad fraction format");
      }
   }   
}
