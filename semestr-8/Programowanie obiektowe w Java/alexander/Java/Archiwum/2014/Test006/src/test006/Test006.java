package test006;
import java.util.*;

public class Test006
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
            System.out.print("Podaj wymiary: ");
            System.out.flush();
            int Y, X;
            if(((Y=readint())>0)&&((X=readint())>0))
            {
                int hy=Y>>1,hx=X>>1;
                String fmt=String.format("%%%dd",2+(int)Math.log10(Y*X));
                for(int by=0,ey=Y-1;by<Y;++by,--ey)
                {
                    for(int bx=0,ex=X-1;bx<X;++bx,--ex)
                    {
                        int p;
                        if(by<=hy)
                        {
                            if(bx>=hx) p=ex>by?0:1;
                            else       p=bx<by?3:0;
                        }
                        else
                        {
                            if(bx>=hx) p=ex<ey?1:2;
                            else       p=bx>ey?2:3;
                        }
                        if(p==3)      p=(1+ex+ey+(2*bx+1)*(-bx+by+ex+ey));
                        else if(p==2) p=(1+ex+ey+(2*ey+1)*(bx+by+ex-ey));
                        else if(p==1) p=(1+3*ex-ey+(2*ex+1)*(bx+by-ex+ey));
                        else          p=(1+4*by-ex-ey+(2*by+1)*(bx-by+ex+ey));
                        System.out.print(String.format(fmt,p));
                    }
                    System.out.println();
                }
                System.out.println("---------------------");

                int tb[][]=new int[Y][X];                
                int up=0,dn=Y-1,lf=-1,rt=X-1,nr=0;
                while((up<=dn)&&(lf<=rt))
                {
                    if(up<=dn) for(int x=++lf;x<=rt;++x) tb[up][x]=++nr;
                    if(lf<=rt) for(int y=++up;y<=dn;++y) tb[y][rt]=++nr;
                    if(up<=dn) for(int x=--rt;x>=lf;--x) tb[dn][x]=++nr;
                    if(lf<=rt) for(int y=--dn;y>=up;--y) tb[y][lf]=++nr;
                }
                for(int y=0;y<Y;++y)
                {
                    for(int x=0;x<X;++x)
                    {
                        System.out.print(String.format(fmt,tb[y][x]));
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
