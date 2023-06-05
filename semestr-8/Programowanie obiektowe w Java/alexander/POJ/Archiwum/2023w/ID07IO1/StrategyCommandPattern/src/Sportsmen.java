public class Sportsmen
{
   private final String name;
   private final SportsmenSwimStrategy stSwim;

   public Sportsmen(String name,SportsmenSwimStrategy stSwim)
   {
      this.name=name;
      this.stSwim=stSwim;
   }

   public String Run() { return "Running"; }
   public String Jump() { return "Jumping"; }
   public String Swim() { return stSwim.Swim(); }
   @Override public String toString() { return name; }
}
