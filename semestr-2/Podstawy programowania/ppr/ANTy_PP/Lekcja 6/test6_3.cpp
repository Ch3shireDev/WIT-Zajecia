// funkcje powI iteracyjnie
#include<stdio.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>
#define REPEAT 2000000
double powI(float base,int exp);
double powR(float base,int exp);

main(){
clock_t start,stop;

printf("Program oblicza potege\n");
printf("-----------------------\n");
printf("\n");
 
float value;
int value2;
float sValue,rValue;
 
printf("Podaj liczbe : ");
scanf("%f", &value);
printf("Podaj liczbe potegi : ");
scanf("%i", &value2);


printf("\n");
start=clock();
for(int i=0; i<REPEAT; i++) {
sValue=powI(value,value2);
}

stop=clock();
printf("Iteracyjnie zrobione w %f s \n",(float)(stop-start)/CLK_TCK);

printf("Wynik %f do %i% = %f\n", value,value2,sValue);
printf("\n\n");
////////////////////////////////////////////////////////////////////////////////
printf("\n");
start=clock();
for(int i=0; i<REPEAT; i++) {
rValue=powR(value,value2);
}
stop=clock();
printf("Rekurencyjnie zrobione w %f s \n",(float)(stop-start)/CLK_TCK);

printf("Wynik %f do %i% = %f\n", value,value2,rValue);
printf("\n\n");

getche();
}

double powI(float base,int exp) {
if(exp==0) { return 1; }
float result;
result=base;
for(int z=0; z<exp; z++) {
if(z>0) {result=result*base;}
}
return result;
}

double powR(float base,int exp) {
if(exp==0) { return 1; }

if(exp%2==0) {
double wynik;
wynik=powR(base,exp/2);
return (wynik*wynik);
//return powR(base,exp/2)*powR(base,exp/2);
}

else {
return base*powR(base,exp-1);
}
}




