
import java.util.List;

public class SportsmanMultiply implements SportsmanCommandComplex {

    private final SportsmanCommand command;
    private final int count;
    private final String name;

    public SportsmanMultiply(SportsmanCommand command, int count, String name) {
        this.command = command;
        this.count = count;
        this.name = name;
    }

    @Override
    public String toString() {
        return this.name;
    }

    @Override
    public String execute(Sportsman sportsman) {
        StringBuilder sb = new StringBuilder();

        sb.append(count).append(" * ")
            .append(command.execute(sportsman));

        return sb.toString();
    }
}
