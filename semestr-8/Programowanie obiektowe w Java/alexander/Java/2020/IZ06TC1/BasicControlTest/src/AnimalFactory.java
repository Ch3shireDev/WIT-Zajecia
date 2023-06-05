public class AnimalFactory 
{
    private static final String[] kinds=new String[]{ "Cat", "Serpent" };
    public static String[] kind()
    {
        return kinds;
    }
    public static Animal make(String kind,String name)
    {
        switch(kind)
        {
            case "Cat": return new Cat(name);
            case "Serpent": return new Serpent(name);
        }
        return null;
    }
}

class Animal
{
    private String name;
    public Animal(String name) { this.name=name; }
    public String path() { return ""; }
    @Override public String toString() { return path() + name; }    
}

class Mammal extends Animal
{
    public Mammal(String name) { super(name); }
    @Override public String path() { return super.path()+"Mammal : "; }
}

class Reptile extends Animal
{
    public Reptile(String name) { super(name); }
    @Override public String path() { return super.path()+"Reptile : "; }
}

class Cat extends Mammal
{
    public Cat(String name) { super(name); }
    @Override public String path() { return super.path()+"Cat : "; }
}

class Serpent extends Reptile
{
    public Serpent(String name) { super(name); }
    @Override public String path() { return super.path()+"Serpent : "; }
}

