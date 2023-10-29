// Konwersja z systemu '10 na '2.
#include <stdio.h>
#define rozm 20
void binarnie(int bin[], int n, int x)
{
 int i=n-1;
while(x/2>0)
{
 bin[i]=x%2;
x=x/2;
i--;
}
bin[i]=1;
}
void zeruj(int tab[], int n)
{
 int i; for(i=0;i<n;i++) tab[i]=0;
}
void wypisz(int tab[], int n)
{
 int i; for(i=0;i<n;i++) printf("%i",tab[i]);
printf("\n");
}
void main()
{
 int t[rozm],li;
zeruj(t,rozm);
fflush(stdin);
scanf("%i", &li);
binarnie(t,rozm,li);
wypisz(t,rozm);
}
