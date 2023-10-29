/*

funkcja wypisz tablice

wypisz glowe(zawartosc 10 elementow pierwszych)
wypisz dupe(zawartosc 10 elementow od dupy)
sortowanie karciane
szukanie max i min
*/


#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#define SIZE 30

void wypiszTablice(int arr[],int x);
void wypelnijTab(int arr[],int x,int od_,int do_);
void wypiszDupe(int arr[],int x);
void wypiszGlowe(int arr[]);
void znajdzMax(int arr[],int i);
void znajdzMin(int arr[],int i);
void InsertSort(int arr[],int s);


main() {
int wartosci_od,wartosci_do;
int tablica[SIZE];

printf("Zakres liczb\nOD : ");
scanf("%i",&wartosci_od);

printf("Zakres liczb\nDO : ");
scanf("%i",&wartosci_do);

wypelnijTab(tablica,SIZE,wartosci_od,wartosci_do);

wypiszTablice(tablica,SIZE);

InsertSort(tablica,SIZE);
printf("Teraz sortuje...\n");
wypiszTablice(tablica,SIZE);
printf("\n\n");

wypiszDupe(tablica,SIZE);
wypiszGlowe(tablica);

znajdzMax(tablica,SIZE);
znajdzMin(tablica,SIZE);
getche();
}


void InsertSort(int arr[],int s) {
int j,pom;

for(int i=1; i<s; i++) {
j=i;
pom=arr[j];
while((j>0) && (arr[j-1]>pom)) {
arr[j]=arr[j-1];
j=j-1;
}
arr[j]=pom;
}
}




void znajdzMax(int arr[],int i) {
int pom;
pom=arr[0];
for(int x=0; x<i; x++) {
if(arr[x]>pom) { pom=arr[x]; }
}

printf("\nNajwieksza wartosc => %i\n",pom);

}


void znajdzMin(int arr[],int i) {
int pom2;
pom2=arr[0];
for(int x=0; x<i; x++) {
if(arr[x]<pom2) { pom2=arr[x]; }
}
printf("\nNajmniejsza wartosc => %i\n",pom2);
}


void wypiszDupe(int arr[],int x){
printf("Wypisuje dupe\n");
for(int i=x-10; i<x; i++) {
printf("\ntablica[%i]=%i",i,arr[i]);
}
}
void wypiszGlowe(int arr[]) {
printf("Wypisuje glowe\n");
for(int i=0; i<10; i++) {
printf("\ntablica[%i]=%i",i,arr[i]);
}

}


void wypelnijTab(int arr[],int x,int od_,int do_) {
int z,result;
z=od_-do_+1;
srand((unsigned) time(0));

for(int i=0; i<x; i++) {
result=rand()%z+od_;
arr[i]=result;
}


}


void wypiszTablice(int arr[],int x) {

for(int i=0; i<x; i++) {
printf("tablica[%i]=%i\n",i,arr[i]);
}

}
