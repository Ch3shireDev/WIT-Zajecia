package test001;
import java.util.*;

public class Test001{
    static Scanner sc=new Scanner(System.in);
    
    public static void main(String[] args) {
        try
        {
            System.out.print("Podaj liczbe A: ");
            System.out.flush();
            int value=sc.nextInt();
            System.out.println("Wprowadzono "+value);
            System.out.printf("Wprowadzono %d\n",value);
        }
        catch(InputMismatchException e)
        {
            System.out.println("Ma być liczba");
        }        
        System.out.print("Podaj liczbe B: ");
        System.out.flush();
        if(sc.hasNextInt())
        {
            int value=sc.nextInt();
            System.out.println("Wprowadzono "+value);
            System.out.printf("Wprowadzono %d\n",value);
            System.out.printf("Pierwiastek %f\n",Math.sqrt(value));
        }
    }
}
