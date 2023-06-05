package test003;
import java.util.*;

public class Test003
{
    static Scanner sc=new Scanner(System.in);
    public static void main(String[] args)
    {
        while(true)
        {
            System.out.print("Podaj wysokość: ");
            System.out.flush();
            if(sc.hasNextInt())
            {
                int h=sc.nextInt(),w=2*h;
                for(int y=h;y>0;--y)
                {
                    for(int x=1;x<w;++x)
                    {
                        System.out.print(x<y||w-x<y?" ":"*");                        
                    }
                    System.out.println();
                }
                for(int x=1;x<h;++x) System.out.print(" ");
                System.out.println("#");
            }
            else if(sc.next().equals("stop")) break;
        }
    }
}
