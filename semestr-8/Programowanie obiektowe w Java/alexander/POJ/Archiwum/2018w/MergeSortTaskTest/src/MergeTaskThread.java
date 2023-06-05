
import java.util.concurrent.locks.ReentrantLock;

public class MergeTaskThread
{
   private final static int ThreadCount=4;
   private final ReentrantLock lock=new ReentrantLock();
   private final int[] st,lf,md,rt,up,tmp,tb;
   private final Thread[] th=new Thread[ThreadCount];
   private int stup,stdn;
   public static void sort(int tb[]) throws InterruptedException
   {
      MergeTaskThread mt=new MergeTaskThread(tb);
      mt.makethreads();
   }
   private void merge(int lf,int mid,int rt)
   {
      int r=lf,p=lf,q=mid;
      while((p<mid)&&(q<rt)) tmp[r++]=(tb[p]<tb[q]?tb[p++]:tb[q++]);
      while(p<mid) tmp[r++]=tb[p++];
      while(q<rt) tmp[r++]=tb[q++];
      for(int i=lf;i<rt;++i) tb[i]=tmp[i];
   }
   private void executethread()
   {
      int pos=st.length;
      while(--pos>=0)
      {
         boolean doit=false;
         lock.lock();
         try
         {
            doit=(st[pos]==2);
            if(doit) st[pos]=3;
         }
         finally { lock.unlock(); }
         if(doit)
         {
//System.err.println("start: ["+pos+"] "+lf[pos]+", "+md[pos]+", "+rt[pos]);
            merge(lf[pos],md[pos],rt[pos]);
            lock.lock();
            try
            {
               System.err.println("done: "+pos);
               if(pos>0)
               {
                  int up=this.up[pos];
                  ++st[up];
//System.err.println("update: ["+up+"] -> "+st[up]);
               }
            }
            finally { lock.unlock(); }
         }
      }
   }
   private void makethreads() throws InterruptedException
   {
      for(int i=0;i<ThreadCount;++i)
      {
         th[i]=new Thread()
         {
            @Override public void run() { executethread(); }
         };
      }
      for(int i=0;i<ThreadCount;++i) th[i].start();
      for(int i=0;i<ThreadCount;++i) th[i].join();
   }
   private MergeTaskThread(int tb[])
   {
      int size=tb.length;
      this.tb=tb;
      tmp=new int[size];
      st=new int[size-1];
      lf=new int[size-1];
      md=new int[size-1];
      rt=new int[size-1];
      up=new int[size-1];
      stup=stdn=0;
      buildtask(size);
   }
   private int findmid(int lf,int rt)
   {
      int n=0,sz=rt-lf-1;
      for(rt=sz;rt!=0;rt>>=1) ++n;
      rt=1<<n;
      return lf+(rt<sz?rt:rt>>1);
   }
   private int state(int size)
   {
      if(size<=1) return 4;
      if(size<=2) return 2;
      if(size<=3) return 1;
      return 0;
   }
   private void buildtask(int size)
   {
      addtask(0,size,-1);
      while(stup<stdn)
      {
         int pos=stup++;
         addtask(lf[pos],md[pos],pos);
         addtask(md[pos],rt[pos],pos);
      }
   }
   private void addtask(int lf,int rt,int up)
   {
      int st=state(rt-lf);
      if(st<4)
      {
         int mid=findmid(lf,rt);
         this.lf[stdn]=lf;
         this.md[stdn]=mid;
         this.rt[stdn]=rt;
         this.st[stdn]=st;
         this.up[stdn]=up;
//System.err.println("stdn="+stdn+"; lf="+lf+"; md="+mid+"; rt="+rt+"; st="+st+";");
         ++stdn;
      }
   }
}
