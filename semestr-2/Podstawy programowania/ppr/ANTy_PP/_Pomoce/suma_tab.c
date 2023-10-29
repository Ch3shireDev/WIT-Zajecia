/* Suma dwoch posortowanych tablic */
#include <stdio.h>
#include <stdlib.h>
#define rozm 10
void suma(int _n[], int a,
int _m[], int b,
int _t[], int c)
{
 int i=0,j=0,k=0;
while(i<a && j<b){
if(_n[i]<_m[j]){
_t[k]=_n[i];
i++;
}else if(_n[i]==_m[j]){
_t[k]=_n[i];
i++; j++;
}else{
_t[k]=_m[j];
j++;
}
k++;
}
while(i<a){
_t[k]=_n[i];
i++; k++;
}
while(j<b){
_t[k]=_m[j];
j++; k++;
}
}
void wyp_z_los_krok(int tab[], int n, int k)
{
 int i;
tab[0]=random(k);
for(i=1;i<n;i++) tab[i]=tab[i-1]+random(k)+1;
}
void zeruj(int tab[], int n)
{
 int i; for(i=0;i<n;i++) tab[i]=0;
}
void wypisz(int tab[], int n)
{
 int i; for(i=0;i<n;i++) printf("%i, ",tab[i]);
printf("\n\n");
}
void main()
{
 int n[rozm], m[2*rozm], t[3*rozm];
randomize();
wyp_z_los_krok(n,rozm,3);
wypisz(n,rozm);
wyp_z_los_krok(m,2*rozm,3);
wypisz(m,2*rozm);
zeruj(t,3*rozm);
suma(n,rozm,m,2*rozm,t,3*rozm);
wypisz(t,3*rozm);
}
