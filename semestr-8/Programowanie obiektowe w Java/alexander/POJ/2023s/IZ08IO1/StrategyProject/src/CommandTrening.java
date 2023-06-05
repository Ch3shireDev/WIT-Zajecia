
import java.util.List;

public class CommandTrening implements SportsmenCommand
{
    private String title;
    private List<SportsmenCommand> commands;    
    public CommandTrening(String title,List<SportsmenCommand> commands)
    {
        this.title = title;
        this.commands = commands;
    }    
    
    @Override public String Execute(Sportsmen sportsmen)
    {
        //StringBuilder sb=new StringBuilder().append("{");
        StringBuilder sb=new StringBuilder();
        sb.append("{");
        boolean first=true;
        for(SportsmenCommand command:commands)
        {
            if(first) first=false; else sb.append(", ");
            sb.append(command.Execute(sportsmen));
        }
        return sb.append("}").toString();
    }    
    @Override public String toString() { return title; }
}
