
public class CommandMultiply implements SportsmanCommand{
    
    private String title;
    private SportsmanCommand command;
    private int count;

    public CommandMultiply(String title, SportsmanCommand command, int count) {
        this.title = title;
        this.command = command;
        this.count = count;
    }

    @Override
    public String Execute(Sportsman sportsman) {
        return String.format("%d x %s", count, command.Execute(sportsman));
}
    
    @Override
    public String toString() {
        return title;
    }
    
}
