/* Program tworzy tablice sum elementow
wszystkich podtablic danej tablicy,
zaczynajacych sie od pozycji 0.
*/
#include <stdio.h>
#include <stdlib.h>
#define rozm 100
void suma_od_0(int tab[], int n, int s_tab[])
{
 int i=0,j=0;
while(i<n){
if(tab[i]==0) j++; else s_tab[j]+=tab[i];
i++;
}
}
void zeruj(int tab[], int n)
{
 int i; for(i=0;i<n;i++) tab[i]=0;
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
 int t[rozm], s_t[rozm];
randomize();
wyp_los(t,rozm,6); zeruj(s_t,rozm);
suma_od_0(t,rozm,s_t);
wypisz(t,rozm);wypisz(s_t,rozm);
}
