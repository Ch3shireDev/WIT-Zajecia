import java.util.List;

public class SportsmenCommandTrening extends SportsmenCommandComplex
{
    private final List<SportsmenCommand> commands;
    public SportsmenCommandTrening(String title, List<SportsmenCommand> commands)
    {
        super(title);
        this.commands = commands;
    }  
    
    @Override public String execute(Sportsmen s)
    { 
        final StringBuilder sb=new StringBuilder().append('{');
        boolean first=true;
        for(SportsmenCommand command : commands)
        {
            if(first) first=false; else sb.append(", ");
            sb.append(command.execute(s));
        }
        return sb.append('}').toString(); 
    }
}
