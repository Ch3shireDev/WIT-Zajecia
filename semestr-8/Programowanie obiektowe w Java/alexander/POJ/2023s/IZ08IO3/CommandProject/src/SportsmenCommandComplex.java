import java.util.List;

public abstract class SportsmenCommandComplex implements SportsmenCommand
{
    private final String title;
    public SportsmenCommandComplex(String title) { this.title = title; }    
    @Override public String toString() { return title; }
}
