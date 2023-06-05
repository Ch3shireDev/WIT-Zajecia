public class Sportsmen
{
   private String surname;
   public Sportsmen(String surname) { this.surname=surname; }
   public String getSurname() { return surname; }

   public String jump() { return "Jumping"; }
   public String run() { return "Running"; }
   public String swim() { return "Swimming"; }
   String execute(SportsmenCommand cmd) { return surname+": "+cmd.execute(this); }
}
