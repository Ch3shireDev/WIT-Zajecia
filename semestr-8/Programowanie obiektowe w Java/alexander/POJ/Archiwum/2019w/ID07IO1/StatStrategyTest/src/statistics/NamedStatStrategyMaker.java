package statistics;

public class NamedStatStrategyMaker implements Comparable<NamedStatStrategyMaker>,IStatStrategyMaker
{
    private final String name;
    private final IStatStrategyMaker maker;
    public NamedStatStrategyMaker(String name,IStatStrategyMaker maker) 
    {
        this.name=name;
        this.maker=maker;
    }
    @Override public IStatStrategy make() { return maker.make(); }
    @Override public String toString() { return name; }    
    @Override public int compareTo(NamedStatStrategyMaker o) { return name.compareTo(o.name); }
}