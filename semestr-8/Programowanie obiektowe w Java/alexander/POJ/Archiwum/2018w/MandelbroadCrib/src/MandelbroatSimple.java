import java.awt.image.BufferedImage;

public class MandelbroatSimple implements MandelbroatImager
{
   @Override public void execute(double tp,double lf,double zoom,BufferedImage img,MandelbroatDone done)
   {
      int W=img.getWidth();
      int H=img.getHeight();
      double mul=MabdelbroadProc.zoom2mul(zoom,W);
      //*///
      int[] map=MabdelbroadProc.makemap(mul,lf,tp,W,H);
      int[] clr=MabdelbroadProc.translate(map);
      img.getRaster().setPixels(0,0,W,H,clr);
      /*///
      for(int h=0;h<H;h+=MabdelbroadProc.partsize)
      {
         int mh=Math.min(MabdelbroadProc.partsize,H-h);
         double Pi=MabdelbroadProc.px2im(mul,tp,h);
         for(int w=0;w<W;w+=MabdelbroadProc.partsize)
         {
            int mw=Math.min(MabdelbroadProc.partsize,W-w);
            double Pr=MabdelbroadProc.px2re(mul,lf,w);
            int[] map=MabdelbroadProc.makemap(mul,Pr,Pi,mw,mh);
            int[] clr=MabdelbroadProc.translate(map);
            img.getRaster().setPixels(w,h,mw,mh,clr);
         }
      }
      //*///
      done.finished(img);
   }
}
