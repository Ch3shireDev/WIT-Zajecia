public class CommandSwim implements Command
{
   public @Override String execute(Sportsmen s) { return s.swim(); }
   public @Override String toString() { return "Swim"; }
}
