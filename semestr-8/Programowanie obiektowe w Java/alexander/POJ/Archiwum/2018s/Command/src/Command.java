public abstract class Command 
{
   public String Execute(Sportsman s)
   {
      return s.getName()+": "+execute(s);
   }
   public abstract String execute(Sportsman s);
}
