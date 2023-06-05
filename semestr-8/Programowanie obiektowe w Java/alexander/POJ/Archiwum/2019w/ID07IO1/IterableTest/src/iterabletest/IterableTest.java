package iterabletest;

import java.util.Iterator;
import java.util.function.Consumer;

public class IterableTest 
{
    public static void main(String[] args) 
    {
        for(int i:new Range(1,1,9))
        {
            System.out.printf("%d ",i);
        }
        System.out.printf("\n");
        new Range(9,-1,1).forEach((i) -> System.out.printf("%d ",i));
        //System.out.printf("\n");
        //for(String s:Animal.Keys()) System.out.printf("%s\n",s);
        new AnimalsTest().setVisible(true);
    }    
}

class Range implements Iterable<Integer>
{
    private final int start,step,end;
    public Range(int start, int step, int end) 
    {
        this.start=start;
        this.step=step;
        this.end=end;
    }
    @Override public RangeIterator iterator() { return new RangeIterator(); }
    private class RangeIterator implements Iterator<Integer>
    {
        private int curr=start;
        @Override public boolean hasNext() 
        {
            return step>0?curr<=end:curr>=end;
        }
        @Override public Integer next() 
        {
            int ret=curr;
            curr+=step;
            return ret;
        }
    }
}
