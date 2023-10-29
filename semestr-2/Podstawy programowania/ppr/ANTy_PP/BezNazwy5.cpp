// stworz tablice i wypisz ja na ekran :D

#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#define SIZE 10

main() {
int Array[SIZE];
int i;

srand((unsigned) time(0));

for(i=0; i<SIZE; i++) {
Array[i]=rand()%10;
//printf("Podaj %i element tablicy : ",i); scanf("%i",&Array[i]);

}

for(i=0; i<SIZE; i++) {
printf("\nArray[%i] => %i",i,Array[i]);
}


getche();

}
