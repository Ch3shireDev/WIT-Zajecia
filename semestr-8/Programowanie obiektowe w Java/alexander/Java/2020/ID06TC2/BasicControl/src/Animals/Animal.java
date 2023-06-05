package Animals;

public class Animal 
{
    private String name;

    public Animal(String name) { this.name=name; }
    public String path() { return ""; }
    @Override public String toString() { return path() + name; }    
}