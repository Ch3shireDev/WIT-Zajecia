import java.util.List;

public class SportsmenCommandMultiply extends SportsmenCommandComplex
{
    private final SportsmenCommand command;
    private final int count;

    public SportsmenCommandMultiply(String title, SportsmenCommand command, int count)
    {
        super(title);
        this.command = command;
        this.count = count;
    }
    
    @Override public String execute(Sportsmen s)
    { 
        return String.format("%d * %s", count, command.execute(s));
    }
}
