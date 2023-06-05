public class SportsmenCommandJump implements SportsmenCommand
{
   public String execute(Sportsman sportsman) { return sportsman.jump(); }
   @Override public String toString() { return "Jump"; }
}
