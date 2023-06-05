public class Trening extends Command
{
   private final Command[] list;
   public Trening(Command[] list)
   {
      this.list=list;
   }
   public @Override String execute(Sportsman s) 
   {
      final StringBuilder sb=new StringBuilder();
      for(Command cmd:list) sb.append(cmd.execute(s)).append('\n');
      return sb.toString().trim().replace("\n", " + ");
   } 
}
