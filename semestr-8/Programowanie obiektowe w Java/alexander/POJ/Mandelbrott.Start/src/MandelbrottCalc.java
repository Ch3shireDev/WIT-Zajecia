public class MandelbrottCalc
{
   public static int[] Calc(MandelbrottTheme theme,double Pi, double Pr)
   {
       int max=theme.getSize()-1,i=0;
       for(double Zr=0,Zi=0;i<max;++i)
       {
           double Tmp=Zr*Zr-Zi*Zi+Pr;
           Zi=2*Zr*Zi+Pi;
           Zr=Tmp;
           if(Zr*Zr+Zi*Zi>=4) return theme.getColor(i);
       }
       return theme.getColor(max);
   }
}
