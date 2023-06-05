import java.util.Arrays;
import java.util.Comparator;
import java.util.HashSet;
import java.util.Objects;
import java.util.stream.Collectors;

public class IdBuilder 
{
    private final HashSet<Long> lst=new HashSet<>();
    private String Delimeter;
    private String Default;
    public IdBuilder(String Delimeter,String Default) 
    {
        setSeparator(Delimeter).setDefault(Default);
    }
    public IdBuilder(String Delimeter) { this(Delimeter,"NULL"); }
    public IdBuilder() { this(", "); }
    public final IdBuilder setSeparator(String Delimeter) { this.Delimeter=Delimeter; return this; }
    public final IdBuilder setDefault(String Default) { this.Default=Default; return this; }
    public IdBuilder append(long id) { lst.add(id); return this; }
    public IdBuilder clear() { lst.clear(); return this; }
    @Override public String toString() 
    {
        if(lst.size()<=0) return Default;
        
        /* Rozwiązanie od Jakub Szota 
        
            Long[] longs = lst.toArray(new Long[0]);
            Arrays.sort(longs);
            return Arrays.stream(longs)
                .map(Objects::toString)
                .collect(Collectors.joining(Delimeter))
            ;
        */
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
        /* Jednowierszowe rozwiązanie całej funkcji
        return lst.stream().sorted(Comparator.naturalOrder()).map(Objects::toString).collect(Collectors.joining(Delimeter));
        */        
    }        
}
