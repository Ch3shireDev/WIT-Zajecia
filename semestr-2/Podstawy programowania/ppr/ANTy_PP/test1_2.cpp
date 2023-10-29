#include<stdio.h>
#include<stdlib.h>
main(){
   printf("Moja wizytowka\n\n");
   printf("+---------------------------------------------+\n");
   printf("| Autor : _____ ________                      |\n");
   printf("| Grupal: _____ ________                      |\n");
   printf("| E-mail: _____ ________                      |\n");
   printf("+---------------------------------------------+\n");
   
   char zn;
   int lc;
   float lf;
   zn = 'a';
   lc = -35;
   lf = 3.4;
   
   printf("Wartosci zmiennych: \n");
   printf("Zmienna zn = %c i jest znakiem\n", zn);
   printf("Zmienna lc = %i i jest calkowita\n", lc);
   printf("Zmienna lf = %f i jest zmiennoprzecinkowa\n", lf);
   
   printf("\n\n");
   system("PAUSE");
}

