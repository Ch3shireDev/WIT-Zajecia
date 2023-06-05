package decoratortest;

public class CarVolvo implements Car
{
   @Override public String Info() { return "Volvo"; }
   @Override public double Price() { return 55000; }
}
