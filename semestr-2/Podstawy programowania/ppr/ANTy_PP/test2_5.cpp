#include<stdio.h>
#include<stdlib.h>

main(){
    float a, b, c;
    float max, suma;

    printf("Podaj a: ");
    scanf("%f", &a);
    printf("Podaj b: ");
    scanf("%f", &b);
    printf("Podaj c: ");
    scanf("%f", &c);
    
    max = a;
    suma = a + b + c;

    if(max < b){
        max = b;
    }

    if(max < c){
    	max = c;
    }


   if(max < (suma - max)){
       printf("Mozna zbudowac trojkat!\n");
   }
   else{
       printf("Nie mozna zbudowac trojkata!\n");
   }

   system("PAUSE");

}

