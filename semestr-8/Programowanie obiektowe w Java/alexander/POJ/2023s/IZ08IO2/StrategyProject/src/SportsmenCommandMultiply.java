public class SportsmenCommandMultiply implements SportsmenCommand
{
    private String title;
    private SportsmenCommand command;
    private int count;

    public SportsmenCommandMultiply(String title, SportsmenCommand command, int count)
    {
        this.title = title;
        this.command = command;
        this.count = count;
    }
        
    @Override public String execute(Sportsmen sportsmen)
    {
        return String.format("%d x %s", count, command.execute(sportsmen));
    }
    
    @Override public String toString() { return title; }
}
