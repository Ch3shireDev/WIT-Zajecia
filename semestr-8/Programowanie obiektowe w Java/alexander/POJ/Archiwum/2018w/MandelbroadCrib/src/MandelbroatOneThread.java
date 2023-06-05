import java.awt.image.BufferedImage;

public class MandelbroatOneThread extends Thread implements MandelbroatImager
{
   private double tp,lf,zoom;
   private BufferedImage img;
   private MandelbroatDone done;

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
      int W=img.getWidth();
      int H=img.getHeight();
      double mul=MabdelbroadProc.zoom2mul(zoom,W);
      int[] map=MabdelbroadProc.makemap(mul,lf,tp,W,H);
      int[] clr=MabdelbroadProc.translate(map);
      img.getRaster().setPixels(0,0,W,H,clr);
      done.finished(img);
   }
}
