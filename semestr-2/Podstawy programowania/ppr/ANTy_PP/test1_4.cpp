#include<stdio.h>
#include<stdlib.h>
main(){
   printf("Prosty kalkulator (sumuje dwie liczby float)\n");
   printf("         y = a + b\n");
   printf("----------------------------------------------\n");
   
   float x1, x2, wynik;

   printf("Podaj liczbe a : ");
   scanf("%f", &x1);
   printf("Podaj liczbe b : ");
   scanf("%f", &x2);

   wynik = x1 + x2;
   
   printf("Wynik %f + %f = %f \n", x1, x2, wynik);
   printf("\n\n");
   system("PAUSE");
}

