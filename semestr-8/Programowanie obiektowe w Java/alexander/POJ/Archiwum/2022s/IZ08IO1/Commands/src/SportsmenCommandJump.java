public class SportsmenCommandJump implements SportsmenCommand
{
   @Override public String Execute(Sportsmen s) { return s.Jump(); }
   @Override public String toString() { return "Jump"; }
}
