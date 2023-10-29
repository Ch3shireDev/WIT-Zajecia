//
// Prosty program... wyznaczniki itp.
//
// Copyright MW

#include<stdio.h>
#include<stdlib.h>
#include<conio.h>
#include<math.h>

// Prototyp funkcji
int liczTo(float a,float b,float c,float *x,float *x1,float *x2);

main() {
float a,b,c;
int wynik;

printf("\n\t**** Witaj w pracy domowej :) y=ax^2+bx+c ***\n\n");
printf("Podaj poprawne wartosci\n\n");

printf("Podaj a : ");	scanf("%f",&a);
printf("Podaj b : ");	scanf("%f",&b);
printf("Podaj c : ");	scanf("%f",&c);
printf("\n\n");

float x=0,x1=0,x2=0;

wynik=liczTo(a,b,c,&x,&x1,&x2);

if(wynik==1) {
printf("Rozwiazanie rownania x=%f\n",x);
}
else if(wynik==2) {
printf("Rozwiazania rownania x1=%f, x2=%f\n",x1,x2);
}
else if(wynik==3) {
printf("To nie jest rownanie kwadratowe\n");
}
else {
printf("Brak rozwiazania rownania\n");
}

printf("\n\n\n\t\t# Copyright 2005 Maciej Wysocki #");
printf("\n\n\nNacisnij dowolny klawisz...");
getche();
}

int liczTo(float a,float b,float c,float *x,float *x1, float *x2) {

if(a==0) { return 3; }
else {
float delta;
delta=b*b-4*a*c;

    if(delta>0) {
    *x1=(-b-sqrt(delta))/(2*a);
    *x2=(-b+sqrt(delta))/(2*a);
    return 2;
    } else if(delta==0) {
    *x=-b/(2*a);
    return 1;
    }
}

}
