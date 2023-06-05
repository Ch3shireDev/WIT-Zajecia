public class SportsmanTrening implements SportsmanComposite
{
   private final String Name;
   private final SportsmanCommand[] List;
   public SportsmanTrening(String Name,SportsmanCommand[] List)
   {
      this.Name=Name;
      this.List=List;
   }
   @Override public String execute(Sportsman s)
   {
      StringBuilder sb=new StringBuilder();
      for(SportsmanCommand cmd:List) sb.append(cmd.execute(s)).append('\t');
      return "("+sb.toString().trim().replace("\t",", ")+")";
   }
   @Override public String toString() { return Name; }
}
