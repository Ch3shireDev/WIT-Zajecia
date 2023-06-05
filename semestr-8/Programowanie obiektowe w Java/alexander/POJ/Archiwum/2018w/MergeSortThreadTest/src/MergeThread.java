
public class MergeThread
{
   private final int[] src;
   private final int[] dst;
   private static void waitfor(Thread th)
   {
      try { if(th!=null) th.join(); }
      catch(InterruptedException ex) {}
   }
   public static void sort(int[] tb)
   {
      final MergeThread mt=new MergeThread(tb);
      waitfor(mt.merge(0,tb.length));
   }
   private Thread merge(int lf,int rt)
   {
      int size=(rt-lf);
      if(size<=1) return null;
      int mid=rt-(size>>1);
      final Thread th=new Thread()
      {
         @Override public void run()
         {
            final Thread tlf=merge(lf,mid);
            final Thread trt=merge(mid,rt);
            waitfor(tlf);
            waitfor(trt);
            int p=lf,q=mid,r=lf;
            while((p<mid)&&(q<rt)) dst[r++]=(src[p]<src[q]?src[p++]:src[q++]);
            while(p<mid) dst[r++]=src[p++];
            while(q<rt) dst[r++]=src[q++];
            for(int i=lf;i<rt;++i) src[i]=dst[i];
         }
      };
      th.start();
      return th;
   }
   private MergeThread(int[] tb)
   {
      src=tb;
      dst=new int[tb.length];
   }
}
