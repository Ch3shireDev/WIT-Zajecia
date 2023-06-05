public class MandelbroatMultiThreadCalc extends Thread
{
   private double mul,Pr,Pi;
   private int w,h,mw,mh;
   private MandelbroatMultiThreadDone done;

   public MandelbroatMultiThreadCalc(double mul,double Pr,double Pi,int w,int h,int mw,int mh,MandelbroatMultiThreadDone done)
   {
      this.mul=mul;
      this.Pr=Pr;
      this.Pi=Pi;
      this.w=w;
      this.h=h;
      this.mw=mw;
      this.mh=mh;
      this.done=done;
   }

   @Override public void run()
   {
      int[] map=MabdelbroadProc.makemap(mul,Pr,Pi,mw,mh);
      done.finished(map,w,h,mw,mh);
   }
}
