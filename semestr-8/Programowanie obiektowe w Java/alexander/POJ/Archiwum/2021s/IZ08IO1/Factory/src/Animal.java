public abstract class Animal
{
   private final String name;
   public Animal(String name) { this.name=name; }
   public String path() { return ""; }
   @Override public String toString()
   {
      return path()+": "+name;
   }
}
