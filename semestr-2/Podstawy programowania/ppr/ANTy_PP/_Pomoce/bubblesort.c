/* Program sortuje tablice nierosnaco algorytmem BubbleSort.
(sortowanie babelkowe) */
#include <stdio.h>
#include <stdlib.h>
#define rozm 20
void zamien(int *a, int *b)
{
 int temp;
temp=*a; *a=*b; *b=temp;
}
void BubbleSort(int tab[], int n)
{
 int i=n-1;
while(i){
if(tab[i]>tab[i-1]){ //wystarczy zmienic znak '<' na '>'
zamien(&tab[i],&tab[i-1]); //zeby otrzymac ciag niemalejacy
i=n-1;
}else
i--;
}
}
void wyp_los(int tab[],int n, int k)
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
BubbleSort(t,rozm);
wypisz(t,rozm);
}
