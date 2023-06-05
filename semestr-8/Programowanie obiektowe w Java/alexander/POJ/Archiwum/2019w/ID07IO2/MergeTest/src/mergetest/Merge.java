package mergetest;

import java.util.concurrent.locks.ReentrantLock;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Merge 
{
    private final ReentrantLock locker=new ReentrantLock();
    private final Thread[] thlist;
    private final double[] tab,add;
    private final byte[] state;
    private Merge(double[] tab,int ThreadCount)
    {
        this.tab=tab;
        add=new double[tab.length];
        thlist=new Thread[ThreadCount];
        state=new byte[tab.length-1];
        for(int i=0;i<ThreadCount;++i) thlist[i]=new Thread(this::run);
        for(int p=0;p<state.length;++p)
        {
            int c2=child(p),c1=c2-1;
            state[p]=(byte)((c1>=state.length?1:0)+(c2>=state.length?1:0));
        }
        for(Thread th:thlist) th.start();
        for(Thread th:thlist) try { th.join(); } catch(Exception ex) {}
    }
    private void run()
    {
        int idx=state.length-1;
        while(true)
        {
            locker.lock();
            try
            {
                while((idx>=0)&&(state[idx]!=2)) --idx;
                if(idx<0) return;
                state[idx]=3;
            }
            finally { locker.unlock(); }
            long map=1;
            int lf=0,rt=tab.length,mid=0;
            for(int p=idx;p>0;p=parent(p)) map=(map<<1)|(p&1);
            for(;;map>>=1)
            {
               int size=rt-lf,sh=0;
               for(int s=size;(s>>=1)>0;++sh) {}
               int p=1<<sh,q=p>>1;
               mid=lf+Math.min(size-q,p);
               if(map<=1) break;
               if((map&1)!=0) rt=mid; else lf=mid;
            }
            int p=lf,a=lf,aEnd=mid,b=mid,bEnd=rt;
            while(a<aEnd && b<bEnd) add[p++]=tab[a]<tab[b]?tab[a++]:tab[b++];
            while(a<aEnd) add[p++]=tab[a++];
            while(b<bEnd) add[p++]=tab[b++];
            for(int i=lf;i<rt;++i) tab[i]=add[i];            
            locker.lock();
            try
            {
                state[idx]=4;
                if(idx>0) ++state[parent(idx)];
System.out.printf("%d: %d..%d..%d |",idx,lf,mid,rt);
for(byte s:state) System.out.printf(" %d",s);
System.out.println();
            }
            finally { locker.unlock(); }
        }
    }
    private static int child(int parent) { return (parent+1)<<1; }
    private static int parent(int child) { return (child-1)>>1; }
    public static void Sort(double[] tb,int ThreadCount)
    {
        new Merge(tb,ThreadCount);
    }
}
