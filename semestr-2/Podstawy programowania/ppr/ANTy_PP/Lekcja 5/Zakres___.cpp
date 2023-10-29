/*

losuje liczbe z podanego zakresu
funkcja podajesz a i b
ona zwraca liczbe losowa z zakresu

*/


#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>

int showZakres(int a,int b);

main() {
int wartosci_od,wartosci_do,z;
int liczba;

printf("Podaj poprawne dane\n\n\n");

printf("Zakres liczb\nOD : ");
scanf("%i",&wartosci_od);

printf("Zakres liczb\nDO : ");
scanf("%i",&wartosci_do);

liczba=showZakres(wartosci_od,wartosci_do);

printf("Liczba z zakresu (%i,%i) => %i",wartosci_od,wartosci_do,liczba);
getche();
}

int showZakres(int a,int b) {
int z,result;

z=a-b+1;

srand((unsigned) time(0));

result=rand()%z+a;
return result;
}

