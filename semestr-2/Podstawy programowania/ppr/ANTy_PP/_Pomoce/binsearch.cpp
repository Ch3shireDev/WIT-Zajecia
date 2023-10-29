/*
posortuj tablice a,b scal itp
wyszukaj wlasnosc binsearchem

zad na tab2d
wylosuj i wypisz
zsumuj wartosci wiersz
kolumny
i tp


*/

/* Program wyszukuje element w posortowanej tablicy metoda BinSearch
(przez polowienie) */
#include<stdio.h>
#include<stdlib.h>
#include<conio.h>
#include<time.h>
#define rozm 20

int BinSearch(int tab[], int n, int el);
void wypisz(int tab[], int n);
void wyp_z_los_krok(int tab[], int n, int k);

main() {
int t[rozm], x, poz;
srand((unsigned) time(0));

wyp_z_los_krok(t,rozm,3);
wypisz(t,rozm);
printf("Prosze podac wartosc elementu x=");
scanf("%i", &x);
poz=BinSearch(t,rozm,x);
if(poz!=-1)
printf("Element %i znajduje sie na pozycji %i", x, poz);
else
printf("Element %i nie nalezy do tablicy.", x);
getche();
}

int BinSearch(int tab[], int n, int el) {
int found=0;
int left=0, right=n-1, mid;
while(left<=right && found==0){
mid=(left+right)/2;
if(tab[mid]==el) found=1;
else if(tab[mid]<el) left=mid+1;
else right=mid-1;
}
if(found==1) return mid;
else return -1;
}

void wyp_z_los_krok(int tab[], int n, int k) {
int i;
tab[0]=rand()%k;
for(i=1;i<n;i++) { tab[i]=tab[i-1]+rand()%k+1; }
}

void wypisz(int tab[], int n) {
int i;
for(i=0; i<n; i++) { printf("%i, ",tab[i]); }
printf("\n");
}

