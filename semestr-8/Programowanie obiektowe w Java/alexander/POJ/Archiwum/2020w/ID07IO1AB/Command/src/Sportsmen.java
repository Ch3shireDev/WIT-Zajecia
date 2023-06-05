public class Sportsmen
{
   private final String Name;
   public Sportsmen(String Name) { this.Name=Name; }
   String run() { return "Running"; }
   String jump() { return "Jumping"; }
   String swim() { return "Swimming"; }
   @Override public String toString() { return Name; }
}
