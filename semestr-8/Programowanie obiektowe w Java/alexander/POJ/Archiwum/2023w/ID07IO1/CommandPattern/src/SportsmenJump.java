public class SportsmenJump implements SportsmenCommand
{
   @Override public String command(Sportsmen s) { return s.Jump(); }
   @Override public String toString() { return "Jump"; }
}
