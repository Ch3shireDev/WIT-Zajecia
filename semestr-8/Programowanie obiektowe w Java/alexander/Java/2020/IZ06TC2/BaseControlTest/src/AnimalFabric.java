public class AnimalFabric 
{
    private static final String[] MAP=new String[] {"Cat","Fly"};
    public static String[] kinds() { return MAP; }
    public static Animal make(String kind,String name)
    {
        switch(kind)
        {
            case "Cat": return new Cat(name);
            case "Fly": return new Fly(name);
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
    @Override public String path() { return super.path() + "Mammal : "; }
}

class Insect extends Animal
{
    public Insect(String name) { super(name); }
    @Override public String path() { return super.path() + "Insect : "; }
}

class Cat extends Mammal
{
    public Cat(String name) { super(name); }
    @Override public String path() { return super.path() + "Cat : "; }
}

class Fly extends Insect
{
    public Fly(String name) { super(name); }
    @Override public String path() { return super.path() + "Fly : "; }
}