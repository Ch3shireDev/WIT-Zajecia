public class Swim implements Command
{
   @Override public String name() { return "swim"; }
   @Override public String execute(Sportsman s) { return s.swim(); }
   @Override public String toString() { return name(); }   
}