//
// Prosty program konwertujacy liczby do dowolnego formatu
//
// Copyright MW

#include<conio.h>
#include<stdio.h>
#include<stdlib.h>
#include<ctype.h>
int liczba,op;
char liczba2[40];

main() {

printf("\n**** Witaj w prostym programie konwertujacym liczby do dowolnego formatu ***\n\n");
printf("Podaj poprawne wartosci\n\n");

printf("\nPodaj liczbe, ktora chcesz konwertowac : ");			scanf("%d",&liczba);

printf("Na jaki system chcesz konwertowac? (2,8,16) : ");	    scanf("%i",&op);

while(op!=2 && op!=8 && op!=16) {
printf("\nMusisz wpisac poprawnie system kodowania !!!\n"); 
printf("Na jaki system chcesz konwertowac? (2,8,16) : ");   	scanf("%i",&op);
}

printf("\n\n\tSystem kodowania : ");

switch(op) {
case 2 : printf("dwojkowy"); break;
case 8 : printf("osemkowy"); break;
case 16 : printf("szesnastkowy"); break;
}

itoa(liczba,liczba2,op);
printf("\n\n\tLiczba po konwersji => %s",liczba2);

printf("\n\n\n\t\t    # Copyright 2005 Maciej Wysocki #");
printf("\n\n\nNacisnij dowolny klawisz...");
getche();
}
