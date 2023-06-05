public class Sportsmen 
{
   private final String name;
   public Sportsmen(String name)
   {
      this.name=name;
   }
   String swim() { return "swim"; }
   String run() { return "run"; }
   String jump() { return "jump"; }
   String execute(Command cmd) { return name+": "+cmd.execute(this); }
}
