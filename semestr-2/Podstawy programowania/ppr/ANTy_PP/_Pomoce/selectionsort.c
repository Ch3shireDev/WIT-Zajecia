/* Program sortuje tablice nierosnaco algorytmem SelectionSort.
(sortowanie przez selekcje) */
#include <stdio.h>
#include <stdlib.h>
#define rozm 20
int max_od(int tab[], int n, int k)
{
 int i, max=tab[k], poz=k;
for(i=k+1;i<n;i++)
if(max<tab[i]){ //wystarczy zmienic znak '<' na '>'
max=tab[i]; //zeby otrzymac ciag niemalejacy
poz=i;
}
return poz;
}
void zamien(int tab[], int i, int j)
{
 int temp;
temp=tab[i]; tab[i]=tab[j]; tab[j]=temp;
}
void SelectionSort(int tab[], int n)
{
 int i,poz;
for(i=0;i<n-1;i++)
if(tab[i]!=tab[poz=max_od(tab,n,i)])
zamien(tab,i,poz);
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
SelectionSort(t,rozm);
wypisz(t,rozm);
}
