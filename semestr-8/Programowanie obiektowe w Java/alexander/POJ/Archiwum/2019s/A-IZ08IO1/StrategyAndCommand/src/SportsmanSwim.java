public class SportsmanSwim implements SportsmanCommand
{
   @Override public String execute(Sportsman s) { return s.Swim(); }
   @Override public String toString() { return "plywanie"; }
}
