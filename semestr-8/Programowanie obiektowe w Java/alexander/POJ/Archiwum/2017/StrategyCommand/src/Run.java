public class Run implements Command
{
   @Override public String name() { return "run"; }
   @Override public String execute(Sportsman s) { return s.run(); }
   @Override public String toString() { return name(); }   
}
