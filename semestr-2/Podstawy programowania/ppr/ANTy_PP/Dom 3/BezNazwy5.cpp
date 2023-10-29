#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
int suma(int a);
int silnia(int a);
main() {
printf("podaj a");
scanf("%a",&a);
int ssuma;
int ssilnia;
suma=suma(a);
ssilnia=silnia(a);
printf("%i",ssuma);
printf("%i",silnia);

}
 

int suma(int a) 
    {
    int suma=0;
    int i=1;
    do
    {
    suma=suma+i;
    i++;
    }
    while(i<=a);
    }
    
    
int silnia(int a)
{
int pom;
pom=1;
for(i=1; i<=liczba; i++) {
tmp=i;
pom=pom*tmp;
}
printf("Silnia : %ld",silnia);
system("pause");
}
