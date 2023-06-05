package basicjava;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.concurrent.atomic.AtomicLong;
import java.util.concurrent.locks.ReentrantLock;

public class BasicJava 
{
    public static void main(String[] args) 
    {
        //Animal[] tb=new Animal[2];
        //tb[1] = new Cat("Puszek");
        //tb[0] = new Fly("Bzz");
        /*
        Animal[] tb=new Animal[]
        {
            new Fly("Bzz"),
            new Cat("Puszek"),
        };
        */
        //for(int i=0;i<tb.length;++i) System.out.println(tb[i]);
        //System.out.println();
        //for(Animal a:tb) System.out.println(a);
        ArrayList<Animal> arr=new ArrayList<Animal>()
        {
            {
                add(new Fly("Bzz"));
                add(new Cat("Puszek"));
            }
        };
        for(int i=0;i<arr.size();++i) System.out.println(arr.get(i));
        System.out.println();
        for(Animal an:arr) System.out.println(an);
        System.out.println();
        int i=0;
        while(i<arr.size())
        {
            System.out.println(arr.get(i++));
        }
        int a,b,c;
        a=2; b=3; c=a*(b++); // 6
        a=2; b=3; c=a*(++b); // 8
        a+=b; // a=a+b;
        a*=b;
        a/=b;
        a%=b;
        a<<=b;
        a>>=b;
        a=9999; c=666;
        //  a=**_** b=_***_
        System.out.printf("%d %d\n",a,b);
        a^=b; // a=*_*_*
        b^=a; // b=**_**
        a^=b; // a=_***_
        System.out.printf("%d %d\n",a,b);
        a|=(1<<b); // ustawić bit nr b w a
        a&=~(1<<b); // usunać bit nr b w a
        a^=(1<<b); // odwrócić bit nr b w a        
        a=5467346;
        int cnt=0;
        for(int k=0;k<32;++k) if((a&(1<<k))==0) ++cnt;
        cnt=0;
        for(int k=0,mask=1;k<32;++k,mask<<=1) if((a&mask)==0) ++cnt;
        for(cnt=0;a!=0;++cnt) a&=(a-1);
        // a = ***___ a-1 = **_***
        
        boolean f=true,g=true,h=true;
        f|=g; // lub
        f&=g; // oraz
        f^=g; // nie równa
              // false false false
              // false true  true
              // true  false true
              // true  true  false
        
        
        HashMap<String,AnimalMaker> map=new HashMap<String,AnimalMaker>()
        {
            {
                put("Cat",(name) -> new Cat(name));
            }  
        };
        
        CompareColor.compare();
        
        Counter=0;
        Thread[] th=new Thread[10];
        for(int j=0;j<th.length;++j) th[j]=new Thread(()->run());
        for(int j=0;j<th.length;++j) th[j].start();
        try
        {
            for(int j=0;j<th.length;++j) th[j].join();
        }
        catch(InterruptedException x) {}
        System.out.printf("Counter=%d;\n", Counter);

        Counter2.set(0);
        for(int j=0;j<th.length;++j) th[j]=new Thread(()->run2());
        for(int j=0;j<th.length;++j) th[j].start();
        try
        {
            for(int j=0;j<th.length;++j) th[j].join();
        }
        catch(InterruptedException x) {}
        System.out.printf("Counter=%d;\n", Counter2.get());
    }
    private static long Counter;
    private static AtomicLong Counter2=new AtomicLong();
    private static final ReentrantLock lock=new ReentrantLock();
    private static void run()
    {
        for(int i=0;i<=1000;++i) 
        {
            lock.lock();
            try
            {
                Counter+=i;
            }
            finally
            {
                lock.unlock();
            }
        }
    }
    private static void run2()
    {
        for(int i=0;i<=1000;++i) 
        {
            Counter2.addAndGet(i);
        }
    }
}

interface AnimalMaker
{
    Animal make(String name);
}

class Animal
{
    private String name;
    public Animal(String name) { this.name=name; }
    public String path() { return ""; }
    @Override public String toString() 
    {
        return path()+name;
    }    
}

class Mammal extends Animal
{
    public Mammal(String name) { super(name); }
    @Override public String path() { return super.path()+"Mammal : "; }
}

class Cat extends Mammal
{
    public Cat(String name) { super(name); }
    @Override public String path() { return super.path()+"Cat : "; }
}

class Insect extends Animal
{
    public Insect(String name) { super(name); }
    @Override public String path() { return super.path()+"Insect : "; }
}

class Fly extends Insect
{
    public Fly(String name) { super(name); }
    @Override public String path() { return super.path()+"Fly : "; }
}