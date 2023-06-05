public class HarmonicCalcSimple extends HarmonicCalc
{
   public HarmonicCalcSimple(long Count,HarmonicCalcDone Done)
   {
      super(Count,Done);
   }
   @Override public void Sum()
   {
      double sum=0;
      for(long i=1;i<=getCount();++i) sum+=1./i;
      CallDone(sum);
   }
}
