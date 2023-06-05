package iterators;

public class NamedTableIteratorMaker implements Comparable<NamedTableIteratorMaker>,ITableIteratorMaker
{
    private final String name;
    private final ITableIteratorMaker maker;
    public NamedTableIteratorMaker(String name,ITableIteratorMaker maker) 
    {
        this.name=name;
        this.maker=maker;
    }
    @Override public ITableIterator make() { return maker.make(); }
    @Override public String toString() { return name; }    
    @Override public int compareTo(NamedTableIteratorMaker o) { return name.compareTo(o.name); }
}