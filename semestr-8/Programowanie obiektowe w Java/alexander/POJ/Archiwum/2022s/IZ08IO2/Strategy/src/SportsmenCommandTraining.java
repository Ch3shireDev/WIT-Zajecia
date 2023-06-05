import java.util.List;

public class SportsmenCommandTraining extends SportsmenCommandComplex
{
   private List<SportsmenCommand> cmds;
   public SportsmenCommandTraining(String name,List<SportsmenCommand> cmds)
   {
      super(name);
      this.cmds=cmds;
   }

   @Override public String execute(Sportsmen sportsmen)
   {
      StringBuilder sb=new StringBuilder().append('{');
      for(int i=0;i<cmds.size();++i)
      {
         if(i>0) sb.append(", ");
         sb.append(cmds.get(i).execute(sportsmen));
      }
      return sb.append('}').toString();
   }
}
