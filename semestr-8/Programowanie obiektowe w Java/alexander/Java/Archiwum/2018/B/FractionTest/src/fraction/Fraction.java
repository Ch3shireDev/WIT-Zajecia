package fraction;

public class Fraction 
{
   private long num,den;

   public long getNum() { return num; }
   public void setNum(long num) { this.num=num; }
   public long getDen() { return den; }
   public void setDen(long den) { this.den=den; }
   public static long hcr(long a,long b)
   {
      if((a==0)&&(b==0)) return 1;
      if(a==0) return b;
      if(b==0) return a;
      a=Math.abs(a);
      b=Math.abs(b);
      while(b!=0)
      {
         long r=a%b;
         a=b;
         b=r;
      }
      return a;
   }
   public Fraction(long num,long den)
   {
      if(den<0)
      {
         num=-num;
         den=-den;
      }
      long n=hcr(num,den);
      this.num=num/n;
      this.den=den/n;
   }

   public static Fraction add(Fraction a,Fraction b)
   {
      return new Fraction(a.num*b.den+b.num*a.den,a.den*b.den);
   }
      
   public static Fraction sub(Fraction a,Fraction b)
   {
      return new Fraction(a.num*b.den-b.num*a.den,a.den*b.den);
   }
   
   public static Fraction mul(Fraction a,Fraction b)
   {
      return new Fraction(a.num*b.num,a.den*b.den);
   }

   public static Fraction div(Fraction a,Fraction b)
   {
      return new Fraction(a.num*b.den,a.den*b.num);
   }

   public @Override String toString() { return num + "/" + den; }
}
