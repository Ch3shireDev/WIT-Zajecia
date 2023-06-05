package test009;

import java.io.IOException;
import java.io.PrintStream;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Test009 
{
    // Szybkie wczytanie dla SPOJ
    static int readint() throws IOException
    {
        int value=0;
        for(boolean ok=false;;ok=true)
        {
            int ch=System.in.read();
            if(('0'<=ch)&&(ch<='9')) value=value*10+(ch-'0'); // nie sprawdzamy przepelnienia bo SPOJ
            else if(ok) return value;
            else throw new IOException("");
        }        
    }    
    static int readsignedint() throws IOException
    {
        int value=0,sign=1;        
        for(boolean ok=false;;ok=true)
        {
            int ch=System.in.read();
            if(('0'<=ch)&&(ch<='9')) value=value*10+(ch-'0'); // nie sprawdzamy przepelnienia bo SPOJ
            else if((ch=='-')&&(!ok)) sign=-1; 
            else if(ok) return sign*value;
            else throw new IOException("");
        }        
    }    
    public static void main(String[] args)
    {
        while(true)
        {
            try
            {
                System.out.print("podaj liczbe: ");
                int x=readsignedint();
                System.out.printf("podano %d\n\n",x);
            }
            catch(IOException e)
            {
                System.out.println("Nie jest to liczba");
                try { while(System.in.read()!=(int)'\n') {} } catch(IOException ee) {}
            }            
        }
    }
}
