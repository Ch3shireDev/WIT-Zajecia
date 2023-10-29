// zsumuj liczby od 1 do podanej przez uzytkownika
#include<stdio.h>
#include<conio.h>
#include<math.h>

main() {
int i,liczba;
long double silnia;
printf("Podaj liczbe, a oblicze silnie : "); scanf("%d",&liczba);

for(silnia=1, i=1; i<=liczba; i++) {
silnia=silnia*i;
}

printf("Silnia = %f",silnia);

getche();
}
