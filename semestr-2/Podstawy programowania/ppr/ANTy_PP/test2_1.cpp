/*
wyswietl wieksza z tych co podane

if wykonuje jedna instrukcje po ifie :D

*/

#include <stdlib.h>
#include <stdio.h>
//#include <time.h>


main(){
float a,b,c,najdluzszy_bok,suma,tmp,max;
printf("Wpisz prosze dlugosc boku a : ");              scanf("%f",&a);

printf("\n\nWpisz prosze dlugosc boku b : ");             scanf("%f",&b);

printf("\n\nWpisz prosze dlugosc boku c : ");           scanf("%f",&c);

printf("Podales a=%f b=%f c=%f\n\n",a,b,c);

if(a>b && a>c) { najdluzszy_bok=a; suma=b+c; }
else if(b>a && b>c) { najdluzszy_bok=b; suma=a+c; tmp=a; a=b; b=tmp; }
else if(c>a && c>b) { najdluzszy_bok=c; suma=b+a; tmp=a; a=c; c=tmp; }

if(c>b) { tmp=b; b=c; c=tmp; }
printf("\n\n\n");
printf("Od najdluzszego :  a=%f b=%f c=%f\n\n",a,b,c);

suma=a+b+c;
max=a;

if(max<(suma-max)) { printf("Da sie zbudowac trojkat"); }
else { printf("Nie da sie zbudowac trojkata"); }
/*
if(najdluzszy_bok<suma) { printf("da sie zbudowac trojkat"); }
else {
    if(a==b && b==c) { printf("da sie zbudowac trojkat rownoboczny");  }
    else { printf("nie da sie zrobic trojkata :("); }
}
*/
printf("\n\n\n");



system("pause");
}
