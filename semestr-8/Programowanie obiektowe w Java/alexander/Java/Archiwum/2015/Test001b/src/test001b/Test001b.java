package test001b;
import java.util.Scanner;

public class Test001b {
    public static Scanner in=new Scanner(System.in);
    
    public static double[][] readMatrix(String name) {
        System.out.print("Podaj ilość wierszy macierzy "+name+": ");
        System.out.flush();
        int Y=in.nextInt();
        if(Y<=0) return null;
        System.out.print("Podaj ilość kolumn macierzy "+name+": ");
        System.out.flush();
        int X=in.nextInt();
        if(X<=0) return null;
        double[][] M=new double[Y][X];
        System.out.println("Podaj elementy macierzy "+name+":");
        for(int y=0;y<Y;++y) for(int x=0;x<X;++x) M[y][x]=in.nextDouble();
        return M;
    }
            
    public static double[][] mulMatrix(double[][] A,double[][] B)
    {
        if(A==null) return null;
        if(B==null) return null;
        int Y=A.length,Z=B.length;
        if((Y<=0)||(Z<=0)) return null;
        int X=B[0].length;
        if(Z!=A[0].length) return null;
        double[][] M=new double[Y][X];
        for(int y=0;y<Y;++y)
        {
            for(int x=0;x<X;++x) 
            {
             double sum=0;
             for(int z=0;z<Z;++z) sum+=A[y][z]*B[z][x];
             M[y][x]=sum;
            }            
        }
        return M;
    }
    
    public static void showMatrix(String Info,double[][] M)
    {
        System.out.println(Info);
        for(int y=0;y<M.length;++y)
        {
            for(int x=0;x<M[y].length;++x) 
            {
                System.out.print(String.format(" %9.3f",M[y][x]));
            }
            System.out.println();
        }
    }

    public static double[][] invMatrix(double[][] M)
    {
        if(M==null) return null;
        int size=M.length;
        if(size!=M[0].length) return null;
        double[][] m=new double[size][size];
        for(int i=0;i<size;++i) m[i][i]=1;
        for(int i=0;i<size;++i)
        {
            double div=M[i][i];
            if(div==0) return null;
            for(int x=0;x<size;++x)
            {
                M[i][x]/=div;
                m[i][x]/=div;
            }
            for(int y=0;y<size;++y)
            {
                if(i!=y)
                {
                    double mul=M[y][i];
                    for(int x=0;x<size;++x)
                    {
                        M[y][x]-=mul*M[i][x];
                        m[y][x]-=mul*m[i][x];
                    }
                }
            }
        }
        return m;
    }
    
    public static void main(String[] args) {
        double[][] C=mulMatrix(readMatrix("A"),readMatrix("B"));
        if(C==null) System.out.println("Nieodpowiednie rozmiary macierzy");
        else
        {
            showMatrix("\nA*B=",C);
            double[][] D=invMatrix(C);
            if(D==null) System.out.println("Nie da się odwrocić");
            else
            {
                showMatrix("\nInv(A*B)=",D);
            }
        }
    }
}
