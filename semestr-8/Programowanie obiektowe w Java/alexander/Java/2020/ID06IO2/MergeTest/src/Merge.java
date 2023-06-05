public class Merge
{
   private final double[] tbl,tmp;
   public static double[] Sort(double[] tbl)
   {
      if(tbl.length>1) new Merge(tbl);
      return tbl;
   }
   private Merge(double[] tbl)
   {
      this.tbl=tbl;
      this.tmp=new double[tbl.length];
      try { MergeThread(0,tbl.length).join(); }
      catch(Exception e) {}
   }
   private Thread MergeThread(int lf,int rt)
   {
      Thread th=new Thread(() -> MergeSort(lf,rt));
      th.start();
      return th;
   }
   private void MergeSort(int lf,int rt)
   {
      int md=(lf+rt)>>1;
      Thread[] th =
      { 
         md-lf>1?MergeThread(lf,md):null,
         rt-md>1?MergeThread(md,rt):null,
      };
      for(Thread thread:th) if(thread!=null)
      {
         try { thread.join(); }
         catch(Exception e) {}
      }
      int ai=lf,ae=md,bi=md,be=rt,ci=lf;
      while((ai<ae)&&(bi<be)) tmp[ci++]=(tbl[ai]<tbl[bi])?tbl[ai++]:tbl[bi++];
      while(ai<ae) tmp[ci++]=tbl[ai++];
      while(bi<be) tmp[ci++]=tbl[bi++];
      for(int i=lf;i<rt;++i) tbl[i]=tmp[i];
   }
}
