// Program wykonuje
// zerowanie tablicy,
// wypelnienie tablicy elementami losowymi,
// odwracanie tablicy w miejscu.
#include <stdio.h>
#include <stdlib.h>
#define rozm 20
void zeruj(int tab[], int n)
{
 int i;
for(i=0;i<n;i++) tab[i]=0;
}
void wyp_los(int tab[], int n, int k)
{
 int i;
for(i=0;i<n;i++) tab[i]=random(k);
}
void odwroc(int tab[], int n)
{
 int i, pom;
for(i=0;i<n/2;i++){
pom=tab[i];
tab[i]=tab[n-i-1];
tab[n-i-1]=pom;
}
}
void wypisz(int tab[], int n)
{
 int i;
for(i=0;i<n;i++) printf("%i, ",tab[i]);
printf("\n");
}
main()
{
 int t[rozm];
zeruj(t,rozm);
wypisz(t,rozm);
randomize();
wyp_los(t,rozm,10);
wypisz(t,rozm);
odwroc(t,rozm);
wypisz(t,rozm);
}
