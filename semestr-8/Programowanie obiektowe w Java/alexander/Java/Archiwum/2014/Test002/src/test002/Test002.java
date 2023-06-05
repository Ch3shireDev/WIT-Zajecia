package test002;
import java.util.*;

public class Test002 {
    static Scanner sc=new Scanner(System.in);
    public static void main(String[] args) {
        while(true)
        {
            System.out.print("Podaj trzy współczynniki: ");
            System.out.flush();
            try
            {
                double A=sc.nextDouble(),B=sc.nextDouble(),C=sc.nextDouble();
                if(A!=0)
                {
                    double delta=B*B-4*A*C;
                    if(delta>0)
                    {
                        delta=Math.sqrt(delta);
                        System.out.printf
                        (
                            "x1 = %f\nx2 = %f\n",
                            (-B+delta)/(2*A),
                            (-B-delta)/(2*A)
                        );
                    }
                    else if(delta==0) System.out.printf("x = %f\n",-B/(2*A));
                    else System.out.println("Brak rozwiązań");
                }
                else if(B!=0) System.out.printf("x = %f\n",-C/B);
                else if(C!=0) System.out.println("Rownanie sprzeczne");
                else System.out.println("x - dowolna wartość jest korzeniem");
            }
            catch(InputMismatchException e)
            {
                System.out.println("Niepoprawne wspolczynniki");
                sc.next();
            }                
        }            
    }
}
