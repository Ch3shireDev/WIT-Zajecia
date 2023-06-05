public class SportsmanJump implements SportsmanCommand
{
   @Override public String execute(Sportsman s) { return s.Jump(); }
   @Override public String toString() { return "skoki"; }
}
