
import java.util.List;

public class SportsmenCommandTrening implements SportsmenCommand
{
    private String title;
    private List<SportsmenCommand> commands;

    public SportsmenCommandTrening(String title, List<SportsmenCommand> commands) 
    {
        this.title = title;
        this.commands = commands;
    }
    
    @Override public String execute(Sportsmen sportsmen)
    {
        StringBuilder sb=new StringBuilder().append("{");
        boolean first=true;
        for (SportsmenCommand command : commands)
        {
            if(first) first=false; else sb.append(", ");
            sb.append(command.execute(sportsmen));
        }
        return sb.append("}").toString();
    }
    
    @Override public String toString() { return title; }    
}
