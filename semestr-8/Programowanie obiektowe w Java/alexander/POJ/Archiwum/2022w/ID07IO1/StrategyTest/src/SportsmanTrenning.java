
import java.util.List;

public class SportsmanTrenning implements SportsmanCommandComplex {

    private final List<SportsmanCommand> commands;
    private final String name;

    public SportsmanTrenning(List<SportsmanCommand> commands, String name) {
        this.name = name;
        this.commands = commands;
    }

    @Override
    public String toString() {
        return this.name;
    }

    @Override
    public String execute(Sportsman sportsman) {
        StringBuilder sb = new StringBuilder();
        boolean first = true;

        sb.append("[");
        for (SportsmanCommand command : this.commands) {
            if (first) {
                first = false;
            } else {
                sb.append(", ");
            }
            sb.append(command.execute(sportsman));
        }
        sb.append("]");

        return sb.toString();
    }
}
