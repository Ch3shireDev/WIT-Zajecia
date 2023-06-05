public class IterableTest 
{
    public static void main(String[] Args)
    {
        for(int i:new Range(1,1,9)) System.out.printf("%d ",i);
        System.out.printf("\n");
        for(int i:new Range(9,-1,1)) System.out.printf("%d ",i);
        System.out.printf("\n");
        
        System.out.printf
        (
            "%s\n",
            new IdBuilder()
            .setSeparator(", ")
            .setEmpty("NULL")
            .append(1)
            .append(3)
            .append(5)
            .append(1)
        );
    }    
}
