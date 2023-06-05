public class CommandRun implements Command
{
   public @Override String execute(Sportsmen s) { return s.run(); }
   public @Override String toString() { return "Run"; }
}
