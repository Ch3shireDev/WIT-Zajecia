public class Jump implements Command
{
   @Override public String name() { return "jump"; }
   @Override public String execute(Sportsman s) { return s.jump(); }
   @Override public String toString() { return name(); }   
}