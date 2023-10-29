#include<stdio.h>
#include<stdlib.h>

main(){
    float a, b, c;
    float suma;

    printf("Podaj a: ");
    scanf("%f", &a);
    printf("Podaj b: ");
    scanf("%f", &b);
    printf("Podaj c: ");
    scanf("%f", &c);
    
    if(a > b)
        if(a > c)
            printf("Najwieksza wartosc to %f.\n", a);
            suma = b+c;
            if(a < suma)
                printf("Mozna zbudowac trojkat!\n");
            else
                printf("Nie mozna zbudowac trojkata!\n");                
        else
            printf("Najwieksza wartosc to %f.\n", c);
            suma = b+a;
            if(c < suma)
                printf("Mozna zbudowac trojkat!\n");
            else
                printf("Nie mozna zbudowac trojkata!\n");                
    else         
        if(b > c)
            printf("Najwieksza wartosc to %f.\n", b);
            suma = c+a;
            if(b < suma)
                printf("Mozna zbudowac trojkat!\n");
            else
                printf("Nie mozna zbudowac trojkata!\n");                
        else
            printf("Najwieksza wartosc to %f.\n", c);
            suma = b+a;
            if(c < suma)
                printf("Mozna zbudowac trojkat!\n");
            else
                printf("Nie mozna zbudowac trojkata!\n");                
    
    system("PAUSE");

}

