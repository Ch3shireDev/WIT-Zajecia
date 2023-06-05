package test002b;

public class Test002b {

    public static void main(String[] args) {
        Animal[] Tb = new Animal[5];
        Tb[0] = new Horse("Fart");
        Tb[1] = new Cat("Mruczek");
        Tb[2] = new Fly("Bzzzyk");
        Tb[3] = new Dragonfly("Baśka");
        Tb[4] = new Horse("Garbusek")
        {
            @Override public String path()
            {
                return super.path()+".Poni"; 
            }
        };        
        for(int i=0;i<Tb.length;++i) System.out.println(Tb[i]);
        System.out.println("------------");
        for(Animal i : Tb) System.out.println(i);
    }
}

class Animal
{
    private String name;
    public Animal(String name) { this.name=name; }
    public static String am_i() { return "Zwierze"; }
    public String path() { return am_i(); }
    @Override public String toString() { return path()+' '+name; }
}

class Mammal extends Animal
{
    public Mammal(String name) { super(name); }
    public static String am_i() { return "Ssak"; }
    @Override public String path() { return super.path()+'.'+am_i(); }
}

class Insect extends Animal
{
    public Insect(String name) { super(name); }
    public static String am_i() { return "Insekt"; }
    @Override public String path() { return super.path()+'.'+am_i(); }
}

class Cat extends Mammal
{
    public Cat(String name) { super(name); }
    public static String am_i() { return "Kot"; }
    @Override public String path() { return super.path()+'.'+am_i(); }
}

class Horse extends Mammal
{
    public Horse(String name) { super(name); }
    public static String am_i() { return "Koń"; }
    @Override public String path() { return super.path()+'.'+am_i(); }
}

class Fly extends Insect
{
    public Fly(String name) { super(name); }
    public static String am_i() { return "Mucha"; }
    @Override public String path() { return super.path()+'.'+am_i(); }
}

class Dragonfly extends Insect
{
    public Dragonfly(String name) { super(name); }
    public static String am_i() { return "Ważka"; }
    @Override public String path() { return super.path()+'.'+am_i(); }
}