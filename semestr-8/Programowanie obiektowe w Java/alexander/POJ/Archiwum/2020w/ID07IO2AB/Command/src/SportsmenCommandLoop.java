

public class SportsmenCommandLoop implements SportsmenCommand
{
   private final String name;
   private final int count;
   private final SportsmenCommand cmd;
   public SportsmenCommandLoop(String name,int count,SportsmenCommand cmd)
   {
      this.name = name;
      this.count = count;
      this.cmd = cmd;
   }
   public String execute(Sportsman sportsman)
   {
      final StringBuilder sb=new StringBuilder();
      for(int i=0;i<count;++i)
      {
         if(i>0) sb.append(", ");
         sb.append(cmd.execute(sportsman));
      }
      return sb.toString();
   }
   @Override public String toString() { return name; }
}
