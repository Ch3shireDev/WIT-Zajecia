public class SportsmenCommandLoop implements SportsmenCommand
{
   private final String name;
   private final int count;
   private final SportsmenCommand cmd;
   public SportsmenCommandLoop(String name,int count,SportsmenCommand cmd)
   {
      this.name=name;
      this.count=count;
      this.cmd=cmd;
   }
   public String execute(Sportsmen sportsmen)
   {
      StringBuilder sb=new StringBuilder();
      for(int i=0;i<count;++i)
      {
         if(i>0) sb.append(", ");
         sb.append(cmd.execute(sportsmen));
      }
      return sb.toString();
   }
}
