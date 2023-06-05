
import java.util.ArrayList;
import java.util.Arrays;

public class StatStrategyTest 
{
    public static void main(String[] args) 
    {
        for(NamedCalcMaker ncm:Fabric.MAP) System.out.printf("%s\n",ncm);
    }
}

class Fabric
{
    public final static NamedCalcMaker[] MAP=new NamedCalcMaker[]
    {
        new NamedCalcMaker("Add",() -> new Add()),
        new NamedCalcMaker("Sub",() -> new Sub()),
        new NamedCalcMaker("Mul",() -> new Mul()),
        new NamedCalcMaker("Div",() -> new Div()),
    };
    static { Arrays.sort(MAP); }
}

interface CalcMaker { Calc make(); }

class NamedCalcMaker implements Comparable<NamedCalcMaker>,CalcMaker
{
    private final String name;
    private final CalcMaker maker;
    public NamedCalcMaker(String name,CalcMaker maker) 
    {
        this.name=name;
        this.maker=maker;
    }
    @Override public Calc make() { return maker.make(); }
    @Override public String toString() { return name; }    
    @Override public int compareTo(NamedCalcMaker o) { return name.compareTo(o.name); }
}

interface Calc
{
    double calc(double a,double b);
}

class Add implements Calc
{
    public double calc(double a,double b) { return a+b; }
}

class Sub implements Calc
{
    public double calc(double a,double b) { return a-b; }
}

class Mul implements Calc
{
    public double calc(double a,double b) { return a*b; }
}

class Div implements Calc
{
    public double calc(double a,double b) { return a/b; }
}