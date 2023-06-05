package test003a;

import java.util.Scanner;

public class Test003a 
{
    public static Scanner in=new Scanner(System.in);
    public static void main(String[] args) 
    {
        Matrix A=Matrix.readMatrix(in, "A");
        Matrix B=Matrix.readMatrix(in, "B");
        Matrix C=Matrix.mulMatrix(A, B);
        if(C == null) System.out.println("Nie odpowiednie wymiary tablic do mnożenia");
        else
        {
            C.showMatrix();
            Matrix D=C.invMatrix();
            if(D == null) System.out.println("Nie odpowiednie wymiary tablicy do odwrócenia");
            else D.showMatrix();
        }
    }
}

final class Matrix
{
    private int Y,X;
    private double[][] tb;
    public int GetY() { return Y; }
    public int GetX() { return X; }
    public double GetValue(int y,int x) { return tb[y][x]; }
    public void SetValue(int y,int x,double value) { tb[y][x]=value; }
    public Matrix(Matrix m)
    {
        SetSize(m.GetY(),m.GetX());
        copy(m);
    }
    public Matrix(int Y,int X)
    {
        SetSize(Y,X);
    }
    public Matrix(int Y,int X,double value)
    {
        SetSize(Y,X);
        init(value);
    }
    public Matrix(int Y,int X,Scanner in)
    {
        SetSize(Y,X);
        read(in);
    }
    public void SetSize(int y,int x)
    {
        Y=y;
        X=x;
        tb = new double[y][x];
    }
    public void copy(Matrix m)
    {
        for(int y=0;y<Y;++y) for(int x=0;x<X;++x) SetValue(y, x, m.GetValue(y, x));
    }
    public void init(double value)
    {
        for(int y=0;y<Y;++y) for(int x=0;x<X;++x) tb[y][x]=value;
    }
    public void read(Scanner in)
    {
        for(int y=0;y<Y;++y) for(int x=0;x<X;++x) tb[y][x]=in.nextDouble();
    }
    public static Matrix readMatrix(Scanner in, String name)
    {
        System.out.print("Podaj ilość wierszy macierzy "+name+": ");
        System.out.flush();
        int Y=in.nextInt();
        if(Y<=0) return null;
        System.out.print("Podaj ilość kolumn macierzy "+name+": ");
        System.out.flush();
        int X=in.nextInt();
        if(X<=0) return null;
        System.out.println("Podaj elementy macierzy "+name+":");
        return new Matrix(Y,X,in);        
    }
    public static Matrix mulMatrix(Matrix A,Matrix B)
    {
        if((A==null)||(B==null)) return null;
        int Y=A.GetY(),Z=B.GetY();
        if((Y==0)||(Z==0)||(A.GetX()!=Z)) return null;
        int X=B.GetX();
        Matrix tb=new Matrix(Y,X);
        for(int y=0;y<Y;++y)
        {
            for(int x=0;x<X;++x)
            {
                double sum=0;
                for(int z=0;z<Z;++z) sum+=A.GetValue(y,z)*B.GetValue(z,x);
                tb.SetValue(y, x, sum);
            }
        }
        return tb;
    }
            
    public void showMatrix()
    {
        for(int y=0;y<Y;++y)
        {
            for(int x=0;x<X;++x)
            {
                System.out.print(String.format(" %9.2f", tb[y][x]));
            }
            System.out.println();
        }
    }
            
    public Matrix invMatrix()
    {
        int size = Y;
        if(size != X) return null;
        Matrix M = new Matrix(this);
        Matrix m = new Matrix(size, size);
        for(int i=0;i<size;++i) m.SetValue(i,i,1);
        for(int i=0;i<size;++i)
        {
            double div=M.GetValue(i, i);
            if(div == 0) return null;
            for(int x=0;x<size;++x)
            {
                M.SetValue(i, x, M.GetValue(i, x) / div);
                m.SetValue(i, x, m.GetValue(i, x) / div);
            }
            for(int y=0; y<size; ++y)
            {
                if(i != y)
                {
                    double mul=M.GetValue(y, i);
                    for(int x=0; x<size; ++x)
                    {
                        M.SetValue(y, x, M.GetValue(y, x) - mul * M.GetValue(i, x));
                        m.SetValue(y, x, m.GetValue(y, x) - mul * m.GetValue(i, x));
                    }
                }
            }
        }
        return m;
    }
}