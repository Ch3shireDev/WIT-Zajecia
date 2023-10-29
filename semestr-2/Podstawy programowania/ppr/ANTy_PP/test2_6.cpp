#include<stdio.h>
#include<stdlib.h>
#include<math.h>

// Rownanie kwadratowe
main(){
    printf("Program szuka rozwiazan rownania postaci y = ax^2 + bx + c\n");
    printf("----------------------------------------------------------\n");
    
    float a, b, c, delta, x1, x2;
    printf("Podaj a:");
    scanf("%f", &a);
    printf("Podaj b:");
    scanf("%f", &b);
    printf("Podaj c:");
    scanf("%f", &c);
    if(a == 0){
        printf("To nie jest rownanie kwadratowe\n");
    }
    else{
        delta = b*b - 4*a*c;
        if(delta > 0){
            x1 = (-b - sqrt(delta))/ (2*a);
            x2 = (-b + sqrt(delta))/ (2*a);
            printf("Rozwiazania rownania x1 = %f, x2 = %f \n", x1, x2);
        }
        else if(delta == 0){
            x1 = x2 = (-b)/ (2*a);
            printf("Rozwiazania rownania x1 = x2 = %f \n", x1);
        }
        else {
            printf("Brak rozwiazana rownania\n");
        }
    }
    system("PAUSE");

}

