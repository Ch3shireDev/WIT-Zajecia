package iterators;

import statistics.*;

public interface ITableIterator
{
    double calc(double[][] tb,IStatStrategy first,IStatStrategy second);
}