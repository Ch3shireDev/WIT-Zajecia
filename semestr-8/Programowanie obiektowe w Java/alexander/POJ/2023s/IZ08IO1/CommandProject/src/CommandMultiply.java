

public class CommandMultiply implements SportsmenCommand
{
    private String title;
    private SportsmenCommand command;
    private int count;

    public CommandMultiply(String title, SportsmenCommand command, int count)
    {
        this.title = title;
        this.command = command;
        this.count = count;
    }
    
    @Override public String Execute(Sportsmen sportsmen)
    {
        return String.format("%d x %s", count, command.Execute(sportsmen));
    }    
    @Override public String toString() { return title; }
}
