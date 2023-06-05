package test003b;

import java.util.Scanner;

public class Test003b {
    public static Scanner in=new Scanner(System.in);
    public static void main(String[] args) {
        matrix A=matrix.read("A",in);
        matrix B=matrix.read("B",in);
        matrix C=matrix.mul(A,B);
        if(C == null) System.out.println("Nie odpowiednie wymiary tablic do mnożenia");
        else
        {
            C.show();
            matrix D=C.inv();
            if(D == null) System.out.println("Nie odpowiednie wymiary tablicy do odwrócenia");
            else D.show();
        }
    }
}
