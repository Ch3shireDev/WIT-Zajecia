public class Sportsman
{
   private final String Name;
   public Sportsman(String Name) { this.Name=Name; }
   public String getName() { return Name; }
   public String Run() { return "biegnę"; }
   public String Jump() { return "skaczę"; }
   public String Swim() { return "plynę"; }
   public String execute(SportsmanCommand cmd)
   {
      return Name+": "+cmd.execute(this);
   }
}
