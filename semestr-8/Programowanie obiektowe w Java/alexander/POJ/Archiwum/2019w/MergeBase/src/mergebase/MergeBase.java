package mergebase;

import java.util.Scanner;

public class MergeBase
{
   private static Scanner sc=new Scanner(System.in);
   private static int[] state;
   private static int child(int parent) { return (parent+1)<<1; }
   private static int parent(int child) { return (child-1)>>1; }

   public static void main(String[] args)
   {
      while(sc.hasNextInt())
      {
         int count=sc.nextInt();
         state=new int[count-1];
         for(int p=0;p<count-1;++p)
         {
            int c2=child(p),c1=c2+1;
            state[p]=(c1>=count?1:0)+(c2>=count?1:0);
         }
         for(int i=0;i<count-1;++i)
         {
            int map=1,lf=0,rt=count,mid=0;
            for(int p=i;p>0;p=parent(p)) map=(map<<1)|(p&1);
            for(;;map>>=1)
            {
               int size=rt-lf,sh=0;
               for(int s=size;(s>>=1)>0;++sh) {}
               int p=1<<sh,q=p>>1;
               mid=lf+Math.min(size-q,p);
               if(map<=1) break;
               if((map&1)!=0) rt=mid; else lf=mid;
            }
            System.out.printf("%d: %d - %d..%d..%d\n",i,state[i],lf,mid,rt);
         }
      }
   }
}
