
import java.util.Arrays;
import java.util.HashSet;
import java.util.stream.Collectors;

public class IdBuilder
{
    private HashSet<Long> set=new HashSet<>();
    private String delimeter=",";
    private String emptystr="null";
    public IdBuilder clear() { set.clear(); return this; }
    public IdBuilder append(long id) { set.add(id); return this; }
    public IdBuilder remove(long id) { set.remove(id); return this; }
    public IdBuilder setDelimeter(String delimeter) { this.delimeter=delimeter; return this; }
    public IdBuilder setEmptyStr(String emptystr) { this.emptystr=emptystr; return this; }
    public String build()
    {
        if(set.isEmpty()) return emptystr;
        //return String.join(delimeter, ids.stream().map(Object::toString).toArray(String[]::new));
        //return String.join(delimeter, set.stream().map(Object::toString).collect(Collectors.toList()));
        StringBuilder sb=new StringBuilder();
        boolean first=true;
        for(long id:set)
        {
            if(first) first=false; else sb.append(delimeter);
            sb.append(id);
        }
        return sb.toString();
    }    
}
