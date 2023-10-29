// Program oblicza maksimum i minimum tablicy.
#include <stdio.h>
#include <stdlib.h>
#define rozm 100
void min_max(int tab[], int *min, int *max, int n)
{
 int i;
*max=*min=tab[0];
for(i=1;i<n;i++){
if(*min>tab[i]) *min=tab[i];
if(*max<tab[i]) *max=tab[i];
}
}
int _min(int tab[], int n)
{
 int i,min=tab[0];
for(i=1;i<n;i++)
if(min>tab[i]) min=tab[i];
return min;
}
int _max(int tab[], int n)
{
 int i,max=tab[0];
for(i=1;i<n;i++)
if(max<tab[i]) max=tab[i];
return max;
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
 int t[rozm], min, max;
randomize();
wyp_los(t,rozm,rozm);
wypisz(t,rozm);
printf("min=%i, max=%i\n", _min(t,rozm), _max(t,rozm));
min_max(t, &min, &max, rozm);
printf("min=%i, max=%i\n", min, max);
}
