public abstract class Animal
{
   private final String name;
   public Animal(String name) { this.name=name; }
   public String path() { return ""; }
   @Override public String toString()
   {
      return name+": "+path();
   }
}

abstract class Insect extends Animal
{
   public Insect(String name) { super(name); }
   @Override public String path() { return super.path()+"/Insect"; }
}

class Fly extends Insect
{
   public Fly(String name) { super(name); }
   @Override public String path() { return super.path()+"/Fly"; }
}
