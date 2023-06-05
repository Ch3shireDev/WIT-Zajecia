public class SportsmanCommandJump implements SportsmanCommand
{
   @Override public String execute(Sportsmen sportsmen) { return sportsmen.jump(); }
   @Override public String toString() { return "Jump"; }
}
