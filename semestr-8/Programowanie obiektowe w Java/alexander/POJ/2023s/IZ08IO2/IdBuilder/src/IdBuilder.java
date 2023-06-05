
import java.util.HashSet;
import java.util.stream.Collectors;

public class IdBuilder
{
    private final HashSet<Long> set=new HashSet<>();
    private String delimeter=", ";
    private String emptyStr="null";
    
    Object setDelimeter(String delimeter) { this.delimeter=delimeter; return this; }
    Object setEmptyStr(String emptyStr) { this.emptyStr=emptyStr; return this; }
    public IdBuilder add(long id) { set.add(id); return this; }
    public IdBuilder remove(long id) { set.remove(id); return this; }
    public IdBuilder clear() { set.clear(); return this; }

    @Override public String toString()
    {
        return 
            (set.isEmpty())?
            emptyStr:
            String.join(delimeter, set.stream().map(id -> Long.toString(id)).collect(Collectors.toList()))
        ;
    }
}
