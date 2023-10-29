/*

wypelniacie losowymi, z zakresu
wypisujecie
wyszukujecie wartosci min i max w tej talicyb

*/

// tablica z danym rozmiarem
// // podaj zakres wypelnienia
// wypelnij losowo
// wyszukujecie min i max wartosc tej tablicy
// wypisujecie ogon(10 ostatnich) i glowa(10 pierwszych) tablicy


#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#define SIZE 30 // ilosc elementow w tablicy

main() {
int array[SIZE];
int wartosci_od,wartosci_do,z;
int i,x,pom,pom2;

printf("Podaj poprawne dane\n\n\n");

printf("Wypelnij tablice liczbami\nOD : ");
scanf("%i",&wartosci_od);

printf("Wypelnij tablice liczbami\nDO : ");
scanf("%i",&wartosci_do);

z=wartosci_do-wartosci_od+1;

srand((unsigned) time(0));

for(i=0; i<SIZE; i++) {
array[i]=rand()%z+wartosci_od;
}

for(x=0, pom=array[0]; x<SIZE; x++) {
if(array[x]>pom) { pom=array[x]; }
}

for(x=0, pom2=array[0]; x<SIZE; x++) {
if(array[x]<pom2) { pom2=array[x]; }
}

for(i=0; i<SIZE; i++) {
if((i>=0 && i<=10) || (i>=SIZE-10)){
printf("\narray[%i] => %i",i,array[i]);
}



}

printf("Najmniejszy element w tablicy => %i\n\nNajwiekszy element w tablicy => %i",pom2,pom);

getche();
}
