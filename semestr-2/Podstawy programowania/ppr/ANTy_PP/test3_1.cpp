// podaj liczbe, oblicze pierwiastek :D
// sqrt nie dziala dla liczb ujemnych :)
// blad domeny blablabla

#include<stdio.h>
#include<conio.h>
#include<math.h>

main() {
float liczba,pier;

printf("Podaj liczbe : "); scanf("%f",&liczba);

while(liczba<=0) {
printf("Zla liczba !!! Podaj liczbe : "); scanf("%f",&liczba);
}

pier=sqrt(liczba);
printf("\n\nPierwiastek z %f = %f",liczba,pier);


getche();
}
