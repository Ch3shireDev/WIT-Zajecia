package test007;
import java.util.*;

public class Test007
{
    static Scanner sc=new Scanner(System.in);
    public static int readint()
    {
        return sc.hasNextInt()?sc.nextInt():0;
    }
    public static int maxcol(int tb[][],int x)
    {
        int max=1;
        for(int y=0;y<tb.length;++y) if(max<tb[y][x]) max=tb[y][x];
        return max;
    }
    public static void main(String[] args)
    {
        while(true)
        {
            System.out.print("Podaj wymiary (stop-koniec): ");
            System.out.flush();
            int Y, X;
            if(((Y=readint())>0)&&((X=readint())>0))
            {
                int tb[][] = new int[Y][X];
                String fmt[] = new String[X];
                for(int x=0;x<X;++x)
                {
                    int max=1;
                    for(int y=0;y<Y;++y)
                    {
                        System.out.print(String.format("T[%d][%d]: ",y,x));
                        System.out.flush();
                        tb[y][x]=sc.nextInt();
                        if(max<tb[y][x]) max=tb[y][x];
                    }
                    fmt[x] = String.format("%%%dd",2+(int)Math.log10(max));
                }
                for(int y=0;y<Y;++y)
                {
                    for(int x=0;x<X;++x)
                    {
                        System.out.print(String.format(fmt[x],tb[y][x]));
                    }
                    System.out.println();
                }
            }
            else if(!sc.next().toLowerCase().equals("stop"))
            {
                System.out.println("Proszę podać dwie liczby naturalne Y X lub wpisać stop ");
            }
            else break;
        }
    }
}
