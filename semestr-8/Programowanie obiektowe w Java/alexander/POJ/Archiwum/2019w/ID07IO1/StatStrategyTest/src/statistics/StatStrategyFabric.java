package statistics;

import java.util.Arrays;

public abstract class StatStrategyFabric implements IStatStrategy
{
    protected double Accumulator;
    protected int Count;
    @Override public void init() { Accumulator=Count=0; }
    @Override public double finish() { return Accumulator; }
    public final static NamedStatStrategyMaker[] MAP=new NamedStatStrategyMaker[]
    {
        new NamedStatStrategyMaker("Min",() -> new StatMin()),
        new NamedStatStrategyMaker("Max",() -> new StatMax()),
        new NamedStatStrategyMaker("Sum",() -> new StatSum()),
        new NamedStatStrategyMaker("Avg",() -> new StatAvg()),
    };
    static { Arrays.sort(MAP); }
}

class StatMin extends StatStrategyFabric
{
    @Override public void proceed(double Value)
    {
        if((0==Count++)||(Accumulator>Value)) Accumulator=Value;
    }
}

class StatMax extends StatStrategyFabric
{
    @Override public void proceed(double Value)
    {
        if((0==Count++)||(Accumulator<Value)) Accumulator=Value;
    }
}

class StatSum extends StatStrategyFabric
{
    @Override public void proceed(double Value) { Accumulator+=Value; ++Count; }
}

class StatAvg extends StatSum
{
    @Override public double finish() { return Accumulator/Count; }
}
