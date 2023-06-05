public class SportsmenJump implements SportsmenCommand
{
   public String execute(Sportsmen sportsmen) { return sportsmen.jump(); }
   @Override public String toString() { return "Jump"; }
}
