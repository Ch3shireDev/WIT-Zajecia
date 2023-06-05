
import java.util.Random;

public class Droper 
{
    private static final Random rnd=new Random();
    private static final int DEC_WEIGHT=50;
    private int Capacity,X;
    public Droper(int Capacity) 
    {
        this.Capacity=Capacity;
        X=100;
    }
    public boolean drop(int[] Heights)
    {
        int Hmid=Heights[X];
        if(Hmid<=0) return false;
        final Grain g=new Grain();
        int Hlf=1000*Math.min(0,Hmid-(X<=0?Hmid-1:Heights[X-1]));
        int Hrt=1000*Math.max(0,(X>=Heights.length?Hmid-1:Heights[X+1])-Hmid);
        int dir=(int)Math.signum(Hlf+rnd.nextInt(Hrt-Hlf));
        int x=X,w=g.getWeight();
        while(dir!=0)
        {
            int nx=x+dir;
            if((0>nx)||(nx>=Heights.length)) dir=0;
            else
            {
                int Hx=Heights[nx],dh=Hmid-Hx;
                if(dh>0) dir=0;
                else
                {
                    Hmid=Hx;
                    w+=DEC_WEIGHT*(dh-1);
                    if(w<0) dir=0;
                }
            }            
        }        
        return true;
    }
}
