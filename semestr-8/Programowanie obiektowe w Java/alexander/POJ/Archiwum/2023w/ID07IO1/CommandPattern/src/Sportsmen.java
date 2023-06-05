public class Sportsmen
{
   private final String name;

   public Sportsmen(String name) { this.name=name; }
   public String Run() { return "Running"; }
   public String Jump() { return "Jumping"; }
   public String Swim() { return "Swiming"; }
   @Override public String toString() { return name; }
}
