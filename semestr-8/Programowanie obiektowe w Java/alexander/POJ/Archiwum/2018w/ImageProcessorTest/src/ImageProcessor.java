public class ImageProcessor
{
   private static int ThreadCount=3;
   private final double[][] mask;
   private final double mul;
   private int masklf,maskrt,masktp,maskbt;
   public ImageProcessor(double[][] mask)
   {
      this.mask=mask;
      int h=mask.length,w=(h>0?mask[0].length:0);
      int sh=h>>1,sw=w>>1;
      masklf=sw;
      maskrt=w-sw;
      masktp=sh;
      maskbt=h-sh;
      mul=calcMul();
   }
   private double calcMul()
   {
      double sum=0;
      for(int y=0;y<mask.length;++y)
      {
         for(int x=0;x<mask[y].length;++x)
         {
            sum+=mask[y][x];
         }
      }
      return 1/sum;
   }
   private void calc(byte[][][] src,byte[] dst,int mx,int my)
   {
      final double[] sum=new double[3];
      if((masklf<=mx)&&(mx<=src[0].length-maskrt)&&(masktp<=my)&&(my<=src.length-maskbt))
      {
         for(int y=0;y<mask.length;++y)
         {
            int py=my+y-masktp;
            for(int x=0;x<mask[y].length;++x)
            {
               int px=mx+x-masklf;
               for(int c=0;c<3;++c) sum[c]+=src[py][px][c];
            }
         }
         for(int c=0;c<3;++c) dst[c]=(byte)Math.round(Math.min(Math.max(mul*sum[c],0),255));
      }
      else
      {
         for(int c=0;c<3;++c) dst[c]=src[my][mx][c];
      }
   }
   private void calcVal(byte[][][] src,byte[][][] dst,int start)
   {
      int Height=src.length;
      for(int y=start;y<Height;y+=ThreadCount)
      {
         int Width=src[y].length;
         for(int x=0;x<Width;++x)
         {
            calc(src,dst[y][x],x,y);
         }
      }
   }
   public byte[][][] proceed(byte[][][] clr) throws InterruptedException
   {
      int Height=clr.length;
      int Width=(Height>0?clr[0].length:0);
      byte[][][] dst=new byte[Height][Width][3];
      Thread[] th=new Thread[ThreadCount];
      for(int t=0;t<ThreadCount;++t)
      {
         final int s=t;
         th[t]=new Thread()
         {
            private int start=s;
            @Override public void run()
            {
               calcVal(clr,dst,start);
            }
         };
      }
      for(int t=0;t<ThreadCount;++t) th[t].start();
      for(int t=0;t<ThreadCount;++t) th[t].join();
      return dst;
   }
}
