/* Program sortuje tablice nierosnaco algorytmem InsertionSort.
(sortowanie przez wstawianie) */
#include <stdio.h>
#include <stdlib.h>
#define rozm 20
void zamien(int tab[], int i, int j)
{
 int temp;
temp=tab[i]; tab[i]=tab[j]; tab[j]=temp;
}
void InsertionSort(int tab[], int n)
{
 int i,j;
for(i=1;i<n;i++){
j=i;
while(j>0 && tab[j]>tab[j-1]){ //wystarczy zmienic znak '<' na '>'
zamien(tab,j,j-1); //zeby otrzymac ciag niemalejacy
j--;
}
}
}
void wyp_los(int tab[], int n, int k)
{
 int i; for(i=0;i<n;i++) tab[i]=random(k);
}
void wypisz(int tab[], int n)
{
 int i; for(i=0;i<n;i++) printf("%i, ",tab[i]);
printf("\n");
}
void main()
{
 int t[rozm];
randomize();
wyp_los(t,rozm,rozm);
wypisz(t,rozm);
InsertionSort(t,rozm);
wypisz(t,rozm);
}
