public class Sportsman 
{
   private String name;
   private final RunStrategy strun;
   private final JumpStrategy stjump;
   private final SwimStrategy stswim;
   public Sportsman(String name,RunStrategy strun,JumpStrategy stjump,SwimStrategy stswim)
   {
      this.name=name;
      this.strun=strun;
      this.stjump=stjump;
      this.stswim=stswim;
   }
   public String getName() { return name; }
   public String run() { return strun.execute(); }
   public String jump() { return stjump.execute(); }
   public String swim() { return stswim.execute(); }
}