public class SportsmanRun implements SportsmanCommand
{
   @Override public String execute(Sportsman s) { return s.Run(); }
   @Override public String toString() { return "bieg"; }
}
