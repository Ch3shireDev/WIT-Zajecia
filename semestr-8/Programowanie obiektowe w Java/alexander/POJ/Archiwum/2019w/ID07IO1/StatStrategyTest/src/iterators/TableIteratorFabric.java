package iterators;

import java.util.Arrays;
import statistics.*;

public abstract class TableIteratorFabric
{
    public final static NamedTableIteratorMaker[] MAP=new NamedTableIteratorMaker[]
    {
        new NamedTableIteratorMaker("Row-Col",() -> new RowCol()),
        new NamedTableIteratorMaker("Col-Row",() -> new ColRow()),
    };
    static { Arrays.sort(MAP); }
}

class RowCol implements ITableIterator
{
    @Override public double calc(double[][] tb,IStatStrategy first,IStatStrategy second)
    {
        first.init();
        for(int y=0;y<tb.length;++y)
        {
            second.init();
            for(int x=0;x<tb[0].length;++x)
            {
                second.proceed(tb[y][x]);
            }
            first.proceed(second.finish());
        }
        return first.finish();
    }    
}

class ColRow implements ITableIterator
{
    @Override public double calc(double[][] tb,IStatStrategy first,IStatStrategy second)
    {
        first.init();
        for(int x=0;x<tb[0].length;++x)
        {
            second.init();
            for(int y=0;y<tb.length;++y)
            {
                second.proceed(tb[y][x]);
            }
            first.proceed(second.finish());
        }
        return first.finish();
    }    
}