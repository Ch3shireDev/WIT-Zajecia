package iterabletest;

import java.util.Arrays;
import java.util.HashMap;

public abstract class Animal 
{
    private final String name;
    public Animal(String name) { this.name=name; }
    public String hierrarchy() { return "Animal"; }
    @Override public String toString() { return hierrarchy()+": "+name; }    
    private static final HashMap<String,MakeAnimal> MAP=new HashMap<String,MakeAnimal>()
    {
        {
            put("Crow",(name) -> new Crow(name));
            put("Eagle",(name) -> new Eagle(name));
        }        
    };
    public static Animal make(String klass,String name)
    {
        return MAP.get(klass).make(name);
    }
    public static String[] Keys()
    {
        String[] ret=new String[MAP.size()];
        MAP.keySet().toArray(ret);
        Arrays.sort(ret);
        return ret;
    }    
}

abstract class Bird extends Animal
{
    public Bird(String name) { super(name); }
    @Override public String hierrarchy() { return super.hierrarchy()+"->"+"Bird"; }
}

abstract class Mammal extends Animal
{
    public Mammal(String name) { super(name); }
    @Override public String hierrarchy() { return super.hierrarchy()+"->"+"Mammal"; }
}

class Crow extends Bird
{
    public Crow(String name) { super(name); }
    @Override public String hierrarchy() { return super.hierrarchy()+"->"+"Crow"; }
}

class Eagle extends Bird
{
    public Eagle(String name) { super(name); }
    @Override public String hierrarchy() { return super.hierrarchy()+"->"+"Eagle"; }
}

class Dog extends Mammal
{
    public Dog(String name) { super(name); }
    @Override public String hierrarchy() { return super.hierrarchy()+"->"+"Dog"; }
}

class Cat extends Mammal
{
    public Cat(String name) { super(name); }
    @Override public String hierrarchy() { return super.hierrarchy()+"->"+"Cat"; }
}

interface MakeAnimal
{
    Animal make(String name);
}