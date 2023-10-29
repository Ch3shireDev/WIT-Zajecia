//
//  Kolejny prosty program :)
//  - wypelnij tablice losowo
//	- wypisz ja
//	- zsumuj wartosci w tabicy
//	- policz parzyste itd.
//
// Copyright MW

#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#define SIZE 10 // ilosc elementow w tablicy

main() {
int array[SIZE];
int suma=0,sumanparz=0,sumaparz=0;
int p=0,n=0,start=0,stop=0;
int i,mod;

printf("\n   **** Witaj w prostym programie sumujacym wartosci tablicy itd. :) ****\n\n");
printf("Podaj poprawne dane\n\n\n");

printf("Sumuj liczby od elementu(min. 0, max. %i) : ",SIZE-1);
scanf("%i",&start);

while(start>=SIZE || start<0) {
printf("Zla ilosc elementow !!! Sumuj liczby od elementu(min. 0, max. %i) : ",SIZE-1);
scanf("%i",&start);
}

printf("Sumuj liczby do elementu(max. %i, min. %i) : ",SIZE,start+1);
scanf("%i",&stop);

while(stop>SIZE || stop<=start) {
printf("Zla ilosc elementow !!! Sumuj liczby do elementu(max. %i, min. %i) : ",SIZE,start+1);
scanf("%i",&stop);
}

system("cls");
printf("\nSumuje od elementu %i do %i...\n",start,stop);
srand((unsigned) time(0));

for(mod=0, i=start; i<stop; i++) {
array[i]=rand()%10;
suma=array[i]+suma;
mod=array[i]%2;
if(mod==0) { sumaparz=sumaparz+array[i]; p++; }
else { sumanparz=sumanparz+array[i]; n++; }
}

for(i=start; i<stop; i++) {
printf("\narray[%i] => %i",i,array[i]);
}
printf("\n\nSuma wszystkich : %i\nSuma parzystych : %i(Elementow : %i)",suma,sumaparz,p);
printf("\nSuma nieparzystych : %i(Elementow : %i)",sumanparz,n);

printf("\n\n\n\t\t# Copyright 2005 Maciej Wysocki #");
printf("\n\n\nNacisnij dowolny klawisz...");
getche();
}
