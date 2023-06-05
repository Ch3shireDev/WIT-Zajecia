
import java.util.List;


public class SportsmanCommandMultiply extends SportsmanCommandComplex{
    private final SportsmanCommand cmd;
    private final int count;

    public SportsmanCommandMultiply(String name, SportsmanCommand cmd, int count) {
        super(name);
        this.cmd = cmd;
        this.count = count;
    }

    @Override
    public String execute(Sportsman sportsman) {
        StringBuilder sb = new StringBuilder();
        sb.append(count).append(" * ").append(cmd.execute(sportsman));

        return sb.toString();
    }
}
