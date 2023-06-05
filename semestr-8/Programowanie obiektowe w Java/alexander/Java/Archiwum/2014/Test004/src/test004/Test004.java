package test004;

public class Test004 {
    public static void main(String[] args) {
        for(int Y=0;Y<8;++Y)
        {
            for(int y=0;y<3;++y)
            {           
                for(int X=0;X<8;++X)
                {
                    for(int x=0;x<5;++x)
                    {           
                        System.out.print(((Y+X)&1)==1?" ":"*");
                    }                    
                }
                System.out.println();
            }
        }
        System.out.println("--------------------------");
        for(int v=0;v<8*3;++v)
        {
            for(int h=0;h<8*5;++h)
            {           
                System.out.print((v/3+h/5)%2==1?" ":"*");
            }
            System.out.println();
        }
    }
}
