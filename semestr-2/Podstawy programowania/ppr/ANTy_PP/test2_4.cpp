#include<stdio.h>
#include<stdlib.h>

main(){
    float a, b, c;
    float tmp;

    printf("Podaj a: ");
    scanf("%f", &a);
    printf("Podaj b: ");
    scanf("%f", &b);
    printf("Podaj c: ");
    scanf("%f", &c);

    if(a < b){
        tmp = b;
        b = a;
        a = tmp;
    }

    if(a < c){
    	tmp = c;
        c = a;
        a = tmp;
    }


   if(a < b + c){
       printf("Mozna zbudowac trojkat!\n");
   }
   else{
       printf("Nie mozna zbudowac trojkata!\n");
   }

   system("PAUSE");

}

