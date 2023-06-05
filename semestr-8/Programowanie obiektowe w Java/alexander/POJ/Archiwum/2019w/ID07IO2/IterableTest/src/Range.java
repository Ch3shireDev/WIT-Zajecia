
import java.util.Iterator;

public class Range implements Iterable<Integer>
{
    private int Start,Step,End;
    public Range(int Start, int Step, int End) 
    {
        this.Start = Start;
        this.Step = Step;
        this.End = End;
    }
    
    private class RangeIterator implements Iterator<Integer>
    {
        private int Current=Start;
        @Override public boolean hasNext() 
        {
            return Step>0?Current<=End:Current>=End;
        }

        @Override public Integer next() 
        {
            int temp=Current;
            Current+=Step;
            return temp;
        }        
    }

    @Override public Iterator<Integer> iterator() 
    {
        return new RangeIterator();
    }    
}
