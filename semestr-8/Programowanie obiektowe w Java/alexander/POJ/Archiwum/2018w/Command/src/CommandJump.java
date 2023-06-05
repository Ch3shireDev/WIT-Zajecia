public class CommandJump implements Command
{
   public @Override String execute(Sportsmen s) { return s.jump(); }
   public @Override String toString() { return "Jump"; }
}
