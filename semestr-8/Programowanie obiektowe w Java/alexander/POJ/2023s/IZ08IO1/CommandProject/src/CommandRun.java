public class CommandRun implements SportsmenCommand
{
    @Override public String Execute(Sportsmen sportsmen)
    {
        return sportsmen.Run();
    }

    @Override public String toString() { return "Run"; }    
}
