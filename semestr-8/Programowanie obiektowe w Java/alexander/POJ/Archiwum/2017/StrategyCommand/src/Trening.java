public class Trening implements Command
{
   private final String _name;
   private final Command[] _list;
   private final static String crlf="\t";
   public Trening(String name,Command[] list)
   {
      _name=name;
      _list=list;
   }
   public Command[] getList() { return _list; }
   @Override public String name() { return _name; }
   @Override public String execute(Sportsman s) 
   {
      //*/// Początek alternatywnego bloku
      final StringBuffer sb=new StringBuffer();
      for(Command cmd : _list)
      {
         sb.append(cmd.execute(s));
         sb.append(crlf);
      }
      return sb.toString().trim().replace("\t", " + ");
      /*/// Alternatyny kod
      String ret="";
      for(Command cmd : _list) 
      {
         ret+=cmd.execute(s)
         ret+crlf;
      }
      return ret.toString().trim().replace("\t", " + ");
      //*/// Koniec alternatywnego bloku
   }
   @Override public String toString() { return name(); }   
}
