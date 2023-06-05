package test010;

import static test010.Mammal.am_i;

public class Test010
{
    public static void main(String[] args)
    {
        Animal[] Tb = new Animal[5];
        Tb[0] = new Cat("Mruczek");
        System.out.printf("-------------------\n");
        Tb[1] = new Horse("Szybki");
        System.out.printf("-------------------\n");
        Tb[2] = new Fly("Bzzzyk");
        System.out.printf("-------------------\n");
        Tb[3] = new Dragonfly("Baśka");
        System.out.printf("-------------------\n");
        Tb[4] = new Horse("Garbusek")
        {
            @Override public String path()
            {
                return super.path()+".Poni"; 
            }
        };        
        System.out.printf("-------------------\n");
        for(int i=0;i<Tb.length;++i) Tb[i].opis();
        System.out.printf("-------------------\n");
        for(int i=0;i<Tb.length;++i) System.out.println(Tb[i]);
    }
}

class Animal
{
    protected String name;
    public Animal(String name)
    {
        this.name=name;
        show();
    }
    public static void show() { System.out.println(am_i()); }
    public static String am_i() { return "Zwierze"; }
    public void opis() { show(); }
    public String path() { return am_i(); }
    @Override public String toString() { return path()+" "+name; }
    //@Override public String toString() { return am_i()+" "+name; }
}

class Mammal extends Animal
{
    public Mammal(String name)
    {
        super(name);
        show();
    }
    //public static void show() { System.out.println(am_i()); }
    public static String am_i() { return "Ssak"; }
    @Override public void opis() { show(); }
    @Override public String path() { return super.path()+"."+am_i(); }
    //@Override public String toString() { return am_i()+"."+super.toString(); }
}

class Insekt extends Animal
{
    public Insekt(String name)
    {
        super(name);
        show();
    }
    //public static void show() { System.out.println(am_i()); }
    public static String am_i() { return "Insekt"; }
    @Override public void opis() { show(); }
    @Override public String path() { return super.path()+"."+am_i(); }
    //@Override public String toString() { return am_i()+"."+super.toString(); }
}

class Cat extends Mammal
{
    public Cat(String name)
    {
        super(name);
        show();
    }
    //public static void show() { System.out.println(am_i()); }
    public static String am_i() { return "Kot"; }
    @Override public void opis() { show(); }
    @Override public String path() { return super.path()+"."+am_i(); }
    //@Override public String toString() { return am_i()+"."+super.toString(); }
}

class Horse extends Mammal
{
    public Horse(String name)
    {
        super(name);
        show();
    }
    //public static void show() { System.out.println(am_i()); }
    public static String am_i() { return "Koń"; }
    @Override public void opis() { show(); }
    @Override public String path() { return super.path()+"."+am_i(); }
    //@Override public String toString() { return am_i()+"."+super.toString(); }
}

class Fly extends Insekt
{
    public Fly(String name)
    {
        super(name);
        show();
    }
    //public static void show() { System.out.println(am_i()); }
    public static String am_i() { return "Mucha"; }
    @Override public void opis() { show(); }
    @Override public String path() { return super.path()+"."+am_i(); }
    //@Override public String toString() { return am_i()+"."+super.toString(); }
}

class Dragonfly extends Insekt
{
    public Dragonfly(String name)
    {
        super(name);
        show();
    }
    //public static void show() { System.out.println(am_i()); }
    public static String am_i() { return "Ważka"; }
    @Override public void opis() { show(); }
    @Override public String path() { return super.path()+"."+am_i(); }
    //@Override public String toString() { return am_i()+"."+super.toString(); }
}
