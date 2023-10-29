//
// Prosty program sluzacy do rozwiazywania ukladu rownan metoda wyznacznikow
// a1*x + b1*y = c1	
// a2*x + b2*y = c2
//
// Copyright MW


#include<stdlib.h>
#include<stdio.h>
#include<conio.h>

main () {
float a1,a2,b1,b2,c1,c2,W,Wx,Wy,x,y;

printf("\n**** Witaj w programie rozwiazujacym uklad rownan metoda wyznacznikow ****");

printf("\n\n\nPodaj wartosci\n\n");
printf("\tWpisz a1 : ");        scanf("%f",&a1);
printf("\tWpisz a2 : ");        scanf("%f",&a2);
printf("\tWpisz b1 : ");        scanf("%f",&b1);
printf("\tWpisz b2 : ");        scanf("%f",&b2);
printf("\tWpisz c1 : ");        scanf("%f",&c1);
printf("\tWpisz c2 : ");        scanf("%f",&c2);

W=(a1*b2)-(a2*b1);
Wx=(c1*b2)-(c2*b1);     Wy=(a1*c2)-(a2*c1);

printf("\n\n// W = %f\n// Wx = %f\n// Wy = %f\n\nOdpowiedz >>>\n",W,Wx,Wy);

if(W<0 || W>0) {
x=Wx/W;     y=Wy/W;
printf("x = %f\ny = %f",x,y);
}
else if(W==0) {
    if(Wx!=0 || Wy!=0) {
    printf("Uklad nie posiada rozwiazan - jest sprzeczny :(");
    }
    else if(Wx==0 && Wy==0) {
    printf("Uklad posiada nieskonczenie wiele rozwiazan :)");
    }
}
printf("\n\n\n\t\t# Copyright 2005 Maciej Wysocki #");
printf("\n\n\nNacisnij dowolny klawisz...");
getche();
}
