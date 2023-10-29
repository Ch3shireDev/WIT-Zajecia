/*

sprawdza, czy z bokow podanych jako parametrow tych funkcji da sie zbudowac trojkat
floaty

czy nie sa ujemne,
zwroc jeden jak da sie zbudowac trojkat




*/
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>

int moznaZbudowac(float a, float b, float c);


main() {
    float a1, a2, a3;

    printf("Podaj a: ");
    scanf("%f", &a1);
    printf("Podaj b: ");
    scanf("%f", &a2);
    printf("Podaj c: ");
    scanf("%f", &a3);
    printf("Boki a = %f b = %f c = %f\n\n",a1,a2,a3);
    if(moznaZbudowac(a1,a2,a3)==1) { printf("MOZNA"); }
    else { printf("NIE MOZNA");}

getche();
}



int moznaZbudowac(float a, float b, float c) {
float suma;

if(a==b && b==c) { return 1; }

   if(a > b){
        if(a > c){
            suma = b+c;
            if(a < suma) { return 1; }
            else { return 0; }
        }
        else{
            suma = b+a;
            if(c < suma) { return 1; }
            else { return 0; }
        }
    }
    else{         
        if(b > c){
            
            suma = c+a;
            if(b < suma) { return 1; }
            else { return 0; }
        }
        else{
            
            suma = b+a;
            if(c < suma) { return 1; }
            else { return 0; }
        }
    }
    
    }

