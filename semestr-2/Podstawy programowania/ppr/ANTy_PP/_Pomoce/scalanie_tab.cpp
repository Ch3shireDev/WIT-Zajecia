/* Scalanie dwoch posortowanych tablic w jedna posortowana
http://wwwzpt.tele.pw.edu.pl/~gborowik/Strona/Dydaktyka_pliki/pp.htm
*/
#include<stdio.h>
#include<stdlib.h>
#include<conio.h>
#include<time.h>
#define rozm 10

void polacz(int _n[], int a, int _m[], int b, int _t[], int c);
void wyp_z_los_krok(int tab[], int n, int k);
void zeruj(int tab[], int n);
void wypisz(int tab[], int n);

main() {
int n[rozm], m[2*rozm], t[3*rozm];

srand((unsigned) time(0));

wyp_z_los_krok(n,rozm,3);
wypisz(n,rozm);
wyp_z_los_krok(m,2*rozm,3);
wypisz(m,2*rozm);
zeruj(t,3*rozm);
polacz(n,rozm,m,2*rozm,t,3*rozm);
wypisz(t,3*rozm);
getche();
}

void polacz(int _n[], int a, int _m[], int b, int _t[], int c) {
int i=0,j=0,k=0;
while(i<a && j<b){
if(_n[i]<_m[j]){
_t[k]=_n[i];
i++;
}else{
_t[k]=_m[j];
j++;
}
k++;
}
while(i<a){
_t[k]=_n[i];
i++;
k++;
}
while(j<b){
_t[k]=_m[j];
j++;
k++;
}
}

void wyp_z_los_krok(int tab[], int n, int k)
{
tab[0]=rand();
for(int i=1;i<n;i++) tab[i]=tab[i-1]+rand()+1;
}

void zeruj(int tab[], int n)
{
for(int i=0;i<n;i++) tab[i]=0;
}

void wypisz(int tab[], int n)
{
for(int i=0;i<n;i++) printf("%i, ",tab[i]);
printf("\n\n");
}
