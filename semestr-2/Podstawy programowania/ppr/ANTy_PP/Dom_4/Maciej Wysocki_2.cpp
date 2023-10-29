//
// Prosty program obliczajacy pierwiastki rowniania kwadratowego
//
// Copyright MW

#include<stdio.h>
#include<conio.h>
#include<math.h>

float rownanie2(float a,float b,float c);

main() {
float a, b, c;

printf("\n**** Witaj w programie obliczajacym pierwiastki rowniania kwadratowego ***\n\n");
printf("Podaj poprawne wartosci\n\n");

printf("\tPodaj a : ");     scanf("%f",&a);
printf("\tPodaj b : ");     scanf("%f",&b);
printf("\tPodaj c : ");     scanf("%f",&c);
printf("\n\ny=ax2+bx+c\n\n");
rownanie2(a,b,c);
printf("\n\n\n\t\t    # Copyright 2005 Maciej Wysocki #");
printf("\n\n\nNacisnij dowolny klawisz...");
getche();
}

float rownanie2(float a,float b,float c) {

float delta, x1, x2;
if(a==0) { printf("To nie jest rownanie kwadratowe\n"); }
else {
delta=b*b-4*a*c;
if(delta>0){
x1=(-b-sqrt(delta))/(2*a);
x2=(-b+sqrt(delta))/(2*a);
printf("x1=%f\nx2=%f", x1, x2);
}
else if(delta==0) {
x1=x2=(-b)/(2*a);
printf("x1=x2=%f\n", x1);
}
else { printf("Brak rozwiazania rownania\n"); }
}

}
