package mergesorttest;

public class Merge 
{
    private final int[] tab;
    private final int[] add;
    public static void sort(int[] tab) { new Merge(tab); }
    private Merge(int[] tab)
    {
        this.tab=tab;
        add=new int[tab.length];
        new MergeTh(0,tab.length).safejoin();
    }
    private class MergeTh extends Thread
    {
        private int aBegin,bEnd;
        public MergeTh(int aBegin,int bEnd)
        {
            this.aBegin=aBegin;
            this.bEnd=bEnd;
            start();
        }
        public void safejoin()
        {
            try { join(); } catch (InterruptedException ex) {}
        }
        @Override public void run()
        {
        }
    }
}
