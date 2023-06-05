package animaltree;

public class Animal 
{
   private String name;
   public Animal(String name)
   {
      this.name=name;
   }
   public String hierarhy()
   {
      return "";
   }
   public void introduce()
   {
      System.out.println(name+": "+hierarhy());
   }
}
