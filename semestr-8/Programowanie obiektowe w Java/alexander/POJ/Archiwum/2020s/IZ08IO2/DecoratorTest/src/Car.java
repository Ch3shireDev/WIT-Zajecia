abstract class Car
{
    abstract String info();
    abstract long price();
    @Override public String toString() { return price()+"\t"+info(); }    
}