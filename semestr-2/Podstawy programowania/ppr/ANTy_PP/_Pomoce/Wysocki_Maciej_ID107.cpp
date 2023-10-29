#include<stdio.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>
#define SIZE 20    // Rozmiar tablicy
#define maxSIZE 60 // Jezeli tablica ma wiecej niz maxSIZE elementow jest wyswietlany tylko przod i tyl

// Deklaracja funkcji
int randVal(int m, int n);
void printTab(int t[], int s);
void losujTab(int t[], int s, int minValue, int maxValue);
void printTableHead(int t[], int s);
void printTableTail(int t[], int s);
void zamien(int *a, int *b);
void BubbleSort(int tab[], int n);
int BinSearch(int tab[], int n, int el);
int findMaxInTable(int t[], int s);
void normalizeIt(int t[], int s, int max);
float liczSrednia(int t[], int s);
int ileWspolnych(int t1[], int t2[], int s);

// Menu programu :)
main() {
// Inicjacja poteznego generatora liczb losowych
srand((unsigned) time(NULL));
clock_t start,stop;

int tA[SIZE];    int tB[SIZE];    int tC[SIZE];
int a,b;

printf("\n**** Witaj na kolokwium :) ***\n\n");

printf("Podaj poprawne dane\n\n\n");
printf("Podaj dolna granice zakresu : ");   scanf("%i",&a);
printf("Podaj gorna granice zakresu : ");   scanf("%i",&b);
if(a>b) { printf("\nPodano zly zakres !!!"); getche(); exit(0); }

start=clock();
// Wypelnia tablice losowymi wartosciami

for(int p=0;p<20000;p++) {
losujTab(tA,SIZE,a,b);
losujTab(tB,SIZE,a,b);
losujTab(tC,SIZE,a,b);
}
stop=clock();
printf("Zrobione w %f s\n",(float)(stop-start)/CLK_TCK);

start=clock();
// Wyszukuje najwiekszego elementu w tablicy ABC
int maxValueA,maxValueB,maxValueC;
maxValueA=findMaxInTable(tA,SIZE);
maxValueB=findMaxInTable(tB,SIZE);
maxValueC=findMaxInTable(tC,SIZE);

printf("Wypisuje tablice A\n");
printTab(tA,SIZE);
printf("Wypisuje tablice B\n");
printTab(tB,SIZE);
printf("Wypisuje tablice C\n");
printTab(tC,SIZE);
stop=clock();
printf("Zrobione w %f s\n",(float)(stop-start)/CLK_TCK);
/*
// Normalizacja
normalizeIt(tA,SIZE,maxValueA);
normalizeIt(tB,SIZE,maxValueB);
normalizeIt(tC,SIZE,maxValueC);


printf("Trwa normalizacja...\n\nWypisuje tablice A\n");

printf("Wypisuje tablice A\n");
printTab(tA,SIZE);
printf("Wypisuje tablice B\n");
printTab(tB,SIZE);
printf("Wypisuje tablice C\n");
printTab(tC,SIZE);
*/

start=clock();
// Licze srednia
float sredniaA,sredniaB,sredniaC;
printf("\nWyliczam srednia...\n");
sredniaA=liczSrednia(tA,SIZE);
sredniaB=liczSrednia(tB,SIZE);
sredniaC=liczSrednia(tC,SIZE);
stop=clock();
printf("Srednia tA=%f tB=%f tC=%f\nZrobione w %f s\n",sredniaA,sredniaB,sredniaC,(float)(stop-start)/CLK_TCK);
/*
// Licze ilosc el. wspolnych tA i tB
int wspAB;
wspAB=ileWspolnych(tA,tB,SIZE);
printf("\nTablice A i B maja %i elementow wspolnych\n",wspAB);
*/
start=clock();
// Sortuje arraye metoda bombelkowa
printf("\nSortuje...\n");
BubbleSort(tA,SIZE);
BubbleSort(tB,SIZE);
BubbleSort(tC,SIZE);

printf("\nPosortowalem... Wypisuje tablice A\n");
printTab(tA,SIZE);
printf("Wypisuje tablice B\n");
printTab(tB,SIZE);
printf("Wypisuje tablice C\n");
printTab(tC,SIZE);

stop=clock();
printf("Zrobione w %f s\n",(float)(stop-start)/CLK_TCK);

start=clock();
// BinSearch
int val,poz;
printf("\nPodaj szukana wartosc : ");     scanf("%i",&val);
poz=BinSearch(tA,SIZE,val);
if(poz!=-1) { printf("\nSzukany element %i znajduje sie na pozycji %i",val,poz); }
else { printf("\nBrak szukanego elementu w tablicy :(",val); }
stop=clock();
printf("\n\nZrobione w %f s\n",(float)(stop-start)/CLK_TCK);

printf("\n\nNacisnij dowolny klawisz...");
// Pauza z conio.h
getche();
}


// Funkcja zwraca randomowa wartosc z przedzialu
int randVal(int m, int n) { return((rand()%(n-m+1))+m); }

// F. wypisuje wartosci arraya
void printTab(int t[], int s) {
printf("\n");
// Sprytne" wypisywanie zawartosci
if(s>maxSIZE) {
printTableHead(t,s);
printTableTail(t,s);
} else {
    for(int i=0;i<s;i++) { printf("Indeks[%i]=>%i\n",i,t[i]);
    }
       }
}

// F. wypelnia arraya losowymi wartosciami
void losujTab(int t[], int s, int minValue, int maxValue) {
    for(int i=0;i<s;i++) { t[i]=randVal(minValue,maxValue); }
}

// F. wypisuje pierwsze 10 elementow arraya
void printTableHead(int t[], int s) {
if(s>10){ s = 10; }
printf("\n");
    for(int i=0;i<s;i++) { printf("Indeks[%i]=>%i\n",i,t[i]); }
}

// F. wypisuje ostatnie 10 el. arraya
void printTableTail(int t[], int s) {
   int tail,i;
      if(s>10) { tail=10; } else { tail = s; }
   i=s-tail;
   printf("\n");
      for(;i<s;i++) { printf("Indeks[%i]=>%i\n",i,t[i]); }
}

// BubbleSorty
void zamien(int *a, int *b) {
int temp;
temp=*a; *a=*b; *b=temp;
}

void BubbleSort(int tab[], int n) {
int i=n-1;
while(i) {
    if(tab[i]<tab[i-1]) {
    zamien(&tab[i],&tab[i-1]);
    i=n-1;
    } else { i--; }
}
}

// BinSearch
int BinSearch(int tab[], int n, int el) {
int found=0;
int left=0, right=n-1, mid;
while(left<=right && found==0) {
mid=(left+right)/2;
if(tab[mid]==el) found=1;
else if(tab[mid]<el) left=mid+1;
else right=mid-1;
}
if(found==1) return mid;
else return -1;
}

// F. znajduje max wartosc w tablicy
int findMaxInTable(int t[], int s) {
int max=t[0];
    for(int i=1;i<s;i++) { if(max<t[i]) max = t[i]; }
    return max;
}

// F. liczy srednia
float liczSrednia(int t[], int s) {
int sumaAll=t[0];
    for(int i=1;i<s;i++) { sumaAll+=t[i]; }
float e=sumaAll/s;
return e;
}

// F. "normalizuje" tablice wersja BETA
void normalizeIt(int t[], int s, int max) {
for(int i=0;i<s;i++) {
t[i]=t[i]/max*100;
}
}



//policz ile elementow wsplnych maja tablice tA i tB wersja BETA
int ileWspolnych(int t1[], int t2[], int s) {
int tmp1,tmp2,count=0,sumka=0,i=0,j=0,g=0;
int jest=0;
int tab[s];


for(;i<s;i++) {
tmp1=t1[i];
               for(;j<s;j++){
               
               tmp2=t2[j];
               if(tmp1==tmp2) {
               if(g==0) { tab[0]=tmp2; }
               printf("JEST");
                              for(;g<=i;g++) {
                              printf("TABG => %i\n\n",tab[g]);
                              if(tab[g]==tmp2) {
                              jest=1;
                              }
                              }
                              
               if(jest==0) { tab[i]=tmp2; count++; }              
               jest=0;               
                             }
               }

}



/*
for(int i=0;i<s;i++) {
tmp1=t1[i];

    for(int j=0;j<s;j++) {
    tmp2=t2[j];
    if(tmp2==tmp1) {
    
    for(int u=0; u<s; u++) {
    if(tab[u]==tmp1) { jest=1; }
    }
     //printf("Wpolne => %i z %i\n",t2[j],tmp1);
     if(jest==0) {           count++;      tab[u]=tmp1;      }
     jest=0;
     }
       }
    
    }
    sumka+=count; count=0;
}
*/
return sumka;
}







