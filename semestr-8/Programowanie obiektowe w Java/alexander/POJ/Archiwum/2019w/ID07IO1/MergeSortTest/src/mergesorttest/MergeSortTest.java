package mergesorttest;

public class MergeSortTest {

    private static final int[] tab={9,5,3,1,4,2,8,6,7};
    private static final int[] add=new int[tab.length];
    public static void srt(int aBegin,int bEnd)
    {
        if(bEnd-aBegin>1)
        {
            int aEnd=(aBegin+bEnd)>>1,bBegin=aEnd;
            srt(aBegin,aEnd);
            srt(bBegin,bEnd);
            int a=aBegin,b=bBegin,p=aBegin;
            while(a<aEnd && b<bEnd) add[p++]=tab[a]<tab[b]?tab[a++]:tab[b++];
            while(a<aEnd) add[p++]=tab[a++];
            while(b<bEnd) add[p++]=tab[b++];
            for(int i=aBegin;i<bEnd;++i) tab[i]=add[i];
        }
    }
    
    public static void main(String[] args) {
         for(int i=0;i<tab.length;++i) System.out.printf("%d, ",tab[i]);
         System.out.printf("\n");
         System.out.printf("\n");
         srt(0,tab.length);
         //Merge.sort(tab);
         for(int i=0;i<tab.length;++i) System.out.printf("%d, ",tab[i]);
         System.out.printf("\n");
         //for(int i=0;i<add.length;++i) System.out.printf("%d, ",add[i]);
    }
    
}
