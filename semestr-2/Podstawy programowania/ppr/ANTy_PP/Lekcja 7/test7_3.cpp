#include<stdio.h>
#include<stdlib.h>
#include<time.h>


// Prototyp funkcji
void swap(int *a, int *b);

void main(){

    printf("Operowanie na wskaznikach \n");
    printf("--------------------------\n");
	printf("\n");

    int x, y;
    printf("Podaj wartosc a : ");
    scanf("%i", &x);
    printf("Podaj wartosc b : ");
    scanf("%i", &y);

    printf("Podane wartosci to a = %i oraz b = %i\n", x, y);
    printf("Wywoluje funkcje swap...");
    swap(&x, &y);
    printf(" zrobione.\n");
    printf("Wartosci po zamianie to a = %i oraz b = %i\n", x, y);
    
	printf("\n");
    system("PAUSE");
} 

void swap(int *a, int *b){
    int tmp = *a;
    *a = *b;
    *b = tmp;
};

