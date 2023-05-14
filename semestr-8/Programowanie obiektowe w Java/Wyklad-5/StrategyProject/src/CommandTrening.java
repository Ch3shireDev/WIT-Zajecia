
import java.util.List;


public class CommandTrening implements SportsmanCommand {
    private String title;
    private List<SportsmanCommand> commands;

    public CommandTrening(String title, List<SportsmanCommand> commands) {
        this.title = title;
        this.commands = commands;
    }

    @Override
    public String Execute(Sportsman sportsman) {
        StringBuilder sb = new StringBuilder()
                .append("{");
        
        for (int i = 0; i < commands.size(); i++) {
            if (i > 0){
                sb.append(", ");
            }
            sb.append(commands.get(i).Execute(sportsman));
        }
        
        return sb.append("}").toString();
    }

    @Override
    public String toString() {
        return title;
    }
    
    
    
}
