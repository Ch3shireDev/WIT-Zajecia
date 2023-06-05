import java.util.Arrays;
import java.util.HashSet;

public class IdBuilder 
{
    private final HashSet<Long> lst=new HashSet<>();
    private String Delimeter;
    private String IfEmpty;
    public IdBuilder(String Delimeter,String IfEmpty) 
    {
        this.Delimeter=Delimeter;
        this.IfEmpty=IfEmpty;
    }
    public IdBuilder(String Delimeter) { this(Delimeter,"NULL"); }
    public IdBuilder() { this(", "); }
    public IdBuilder setDelimeter(String Delimeter) { this.Delimeter=Delimeter; return this; }
    public IdBuilder setIfEmpty(String IfEmpty) { this.IfEmpty=IfEmpty; return this; }
    public IdBuilder append(long id) { lst.add(id); return this; }
    public IdBuilder clear() { lst.clear(); return this; }
    @Override public String toString() 
    {
        if(lst.size()<=0) return IfEmpty;
        Long[] tb=new Long[lst.size()];
        lst.toArray(tb);
        Arrays.sort(tb);
        final StringBuilder sb=new StringBuilder();
        //*///
        sb.append(tb[0]);
        for(int i=1;i<tb.length;++i) sb.append(Delimeter).append(tb[0]);
        /*/
        boolean first=true;
        for(long id:tb)
        {
            if(first) first=false;
            else sb.append(Delimeter);
            sb.append(id);
        }        
        //*///
        return sb.toString();
    }        
}
