//
// Program liczacy najwiekszy wspolny dzielnik dwoch liczb
// 
// Copyright MW

#include<stdio.h>
#include<conio.h>
#include<stdlib.h>

int NWD(int x,int y,int i=0);

main() {
int a,b,wynik;

printf("\n\t**** Witaj w programie obliczajacym NWD dwoch liczb ***\n\n");
printf("Podaj poprawne wartosci\n\n");

printf("\tPodaj pierwsza liczbe : ");     scanf("%d",&a);
printf("\tPodaj druga liczbe : ");        scanf("%d",&b);

printf("\n\n");

wynik=NWD(a,b);

printf("\n\nNWD(%d,%d)=%d",a,b,wynik);
printf("\n\n\n\t\t    # Copyright 2005 Maciej Wysocki #");
printf("\n\n\nNacisnij dowolny klawisz...");
getche();
}

int NWD(int m,int n,int i=0) {
if(m>=n && m%n==0) { return n; }
else { i++; printf("%i] ",i);
if(m<n) { printf("NWD(%d,%d)\n",n,m); return NWD(n,m,i); }
else { printf("NWD(%d,%d)\n",n,m%n); return NWD(n,m%n,i); }
}
}
