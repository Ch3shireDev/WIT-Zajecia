package test008;
import java.util.*;

public class Test008
  {
    static Scanner sc=new Scanner(System.in);
    public static int readint()
    {
        return sc.hasNextInt()?sc.nextInt():0;
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
                Matrix A=new Matrix(Y,X);
                A.read(sc);
                System.out.println("\nA:");
                A.show();
                if(((Y=readint())>0)&&((X=readint())>0))
                {
                    Matrix B=new Matrix(Y,X);
                    B.read(sc);
                    System.out.println("\nB:");
                    B.show();
                    Matrix C=Matrix.multiply(A,B);
                    if(C!=null)
                    {
                        System.out.println("\nC:");
                        C.show();
                    }
                    else System.out.println("Nieodpowiednie rozmiary macierzy");
                }
                else if(!sc.next().toLowerCase().equals("stop"))
                {
                    System.out.println("Proszę podać dwie liczby naturalne Y X lub wpisać stop ");
                }
                else break;
            }
            else if(!sc.next().toLowerCase().equals("stop"))
            {
                System.out.println("Proszę podać dwie liczby naturalne Y X lub wpisać stop ");
            }
            else break;
        }        
    }
}

class Matrix
{
    double T[][];
    Matrix(int Y,int X)
    {
        T = new double [Y][X];
    }
    void read(Scanner sc)
    {
        for(int y=0;y<T.length;++y)
        {
            for(int x=0;x<T[y].length;++x)
            {
                System.out.print(String.format("T[%d][%d]: ",y,x));
                System.out.flush();
                T[y][x]=readdouble(sc);
            }
        }
    }
    public static double readdouble(Scanner sc)
    {
        return sc.hasNextDouble()?sc.nextDouble():0;
    }
    public static Matrix multiply(Matrix A,Matrix B)
    {
        int Y=A.T.length,X=B.T[0].length,Z=B.T.length;
        for(int z=0;z<Z;++z) if(B.T[z].length!=X) return null;
        for(int y=0;y<Y;++y) if(A.T[y].length!=Z) return null;
        Matrix C=new Matrix(Y,X);
        for(int y=0;y<Y;++y)
        {
            for(int x=0;x<X;++x)
            {
                double sum=0;
                for(int z=0;z<Z;++z) sum+=A.T[y][z]*B.T[z][x];
                C.T[y][x]=sum;
            }
        }
        return C;
    }
    public void show()
    {
        for(int y=0;y<T.length;++y)
        {
            for(int x=0;x<T[y].length;++x)
            {
                System.out.printf("\t%8.4f",T[y][x]);
            }
            System.out.println();
        }    
    }
}