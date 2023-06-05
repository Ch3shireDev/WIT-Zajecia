
import java.util.List;


public class SportsmanCommandTrening extends SportsmanCommandComplex{
    private final List<SportsmanCommand> comandsList;

    public SportsmanCommandTrening(String name, List<SportsmanCommand> comandsList) {
        super(name);
        this.comandsList = comandsList;
    }

    @Override
    public String execute(Sportsman sportsman) {
        StringBuilder sb = new StringBuilder();
        boolean is_first = true;
        sb.append("{");
        for(SportsmanCommand command: comandsList) {
            if(is_first) is_first = false;
            else sb.append(", ");
            sb.append(command.execute(sportsman));
        }
        return sb.append("}").toString();
    }
}
