
import java.util.List;

public class SportsmenCommandTrening extends SportsmenCommandComplex
{
   private List<SportsmenCommand> list;
   public SportsmenCommandTrening(String name,List<SportsmenCommand> list)
   {
      super(name);
      this.list=list;
   }
   @Override public String execute(Sportsmen sportsmen)
   {
      StringBuilder sb=new StringBuilder();
      for(int i=0;i<list.size();++i)
      {
         if(i>0) sb.append(", ");
         sb.append(list.get(i).execute(sportsmen));
      }
      return "["+sb.toString()+"]";
   }
}
