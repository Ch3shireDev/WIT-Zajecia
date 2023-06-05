import java.awt.image.BufferedImage;
import java.util.concurrent.atomic.AtomicInteger;

public class MandelbroatMultiThread extends Thread implements MandelbroatImager
{
   private double tp,lf,zoom;
   private BufferedImage img;
   private MandelbroatDone done;
   private final AtomicInteger count=new AtomicInteger();

   @Override public void execute(double tp,double lf,double zoom,BufferedImage img,MandelbroatDone done)
   {
      this.tp=tp;
      this.lf=lf;
      this.zoom=zoom;
      this.img=img;
      this.done=done;
      start();
   }

   @Override public void run()
   {
      count.set(1);
      int W=img.getWidth();
      int H=img.getHeight();
      double mul=MabdelbroadProc.zoom2mul(zoom,W);
      for(int h=0;h<H;h+=MabdelbroadProc.partsize)
      {
         int mh=Math.min(MabdelbroadProc.partsize,H-h);
         double Pi=MabdelbroadProc.py2im(mul,tp,h);
         for(int w=0;w<W;w+=MabdelbroadProc.partsize)
         {
            int mw=Math.min(MabdelbroadProc.partsize,W-w);
            double Pr=MabdelbroadProc.px2re(mul,lf,w);
            count.incrementAndGet();
            new MandelbroatMultiThreadCalc(mul,Pr,Pi,w,h,mw,mh,this::finished).start();
         }
      }
      count.decrementAndGet();
   }

   private void finished(int[] map,int w,int h,int mw,int mh)
   {
      synchronized(this)
      {
         int[] clr=MabdelbroadProc.translate(map);
         img.getRaster().setPixels(w,h,mw,mh,clr);
      }
      if(count.decrementAndGet()<=0) done.finished(img);
   }
}
