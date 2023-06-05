package test003b;

import java.util.Scanner;

public final class matrix {
    private int Y,X;
    private double[][] tb;
    public int getY() { return Y; }
    public int getX() { return X; }
    public double getVal(int y, int x) { return tb[y][x]; }
    public void setVal(int y, int x, double val) { tb[y][x]=val; }
    public matrix(int y, int x)
    {
        resize(y, x);
    }
    public matrix(matrix m)
    {
        this(m.getY(), m.getX());
        copy(m);
    }
    public matrix(int y, int x, Scanner in)
    {
        this(y, x);
        read(in);
    }
    public void resize(int y, int x)
    {
        Y = y;
        X = x;
        tb = new double[Y][X];
    }
    public void copy(matrix m)
    {
        //for(int y=0;y<Y;++y) for(int x=0;x<X;++x) setVal(y, x, m.getVal(y, x));
        for(int y=0;y<Y;++y) System.arraycopy(m.tb, 0, tb, 0, tb.length);
    }
    public void show()
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
    public static matrix mul(matrix A, matrix B)
    {
        if((A==null)||(B==null)) return null;
        int Y=A.getY(),Z=B.getY();
        if((Y==0)||(Z==0)||(A.getX()!=Z)) return null;
        int X=B.getX();
        matrix m=new matrix(Y,X);
        for(int y=0;y<Y;++y)
        {
            for(int x=0;x<X;++x)
            {
                double sum=0;
                for(int z=0;z<Z;++z) sum+=A.getVal(y, z)*B.getVal(z, x);
                //for(int z=0;z<Z;++z) sum+=A[y][z]*B[z][x];
                m.setVal(y, x, sum);
                //m.tb[y][x] = sum;
            }
        }
        return m;
    }
    public matrix inv()
    {
        int size=getY();
        if(size!=getX()) return null;
        matrix M=new matrix(this);
        matrix m=new matrix(size,size);
        for(int i=0;i<size;++i) m.setVal(i, i, 1);
        for(int i=0;i<size;++i)
        {
            double div=M.getVal(i, i);
            if(Math.abs(div)<1E-20) return null;
            for(int x=0;x<size;++x)
            {
                M.setVal(i, x, M.getVal(i, x) / div);
                m.setVal(i, x, m.getVal(i, x) / div);
            }
            for(int y=0;y<size;++y)
            {
                if(i!=y)
                {
                    double mul=M.getVal(y,i);
                    for(int x=0;x<size;++x)
                    {
                        M.setVal(y, x, M.getVal(y, x) - mul * M.getVal(i, x));
                        m.setVal(y, x, m.getVal(y, x) - mul * m.getVal(i, x));
                    }
                }
            }
        }
        return m;
    }
    public void read(Scanner in)
    {
        for(int y=0;y<Y;++y) for(int x=0;x<X;++x) tb[y][x]=in.nextDouble();
    }
    public static matrix read(String name, Scanner in)
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
        return new matrix(Y, X, in);
    }
}
