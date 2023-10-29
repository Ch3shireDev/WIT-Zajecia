#include<stdio.h>
#include<stdlib.h>
#include<time.h>

#define SIZE 20

// Prototyp funkcji
void cleverPrintTab(int t[], int s);
void fillTab(int t[], int s, int minValue, int maxValue);

void main(){

    printf("Operowanie na wskaznikach \n");
    printf("--------------------------\n");
	printf("\n");

    int tab[SIZE];
    printf("Losuje zawartosc tablic:\n");
    fillTab(tab, SIZE, 1, 9);	
	printf("\n");

    printf("Wypisuje tablice A:\n");
	cleverPrintTab(tab, SIZE);
	printf("\n");
    
	printf("\n");
    system("PAUSE");

    printf("Ustawiam wskaznik na pierwszy element tablicy:\n");
    long double *wsk_ld = (long double *)&tab[0];
    printf("Zawartosc wsk_ld = %p\n", wsk_ld);
    printf("Zawartosc pamieci pod adresem wsk_ld = %i\n", *wsk_ld);

	printf("\n");
    system("PAUSE");

    printf("Ustawiam wskaznik na kolejny element tablicy:\n");
    wsk_ld ++;
    printf("Zawartosc wsk_ld = %p\n", wsk_ld);
    printf("Zawartosc pamieci pod adresem wsk_ld = %i\n", *wsk_ld);

    printf("Cofam wskaznik na pierwszy element tablicy:\n");
    wsk_ld --;
    printf("Zawartosc wsk_ld = %p\n", wsk_ld);
    printf("Zawartosc pamieci pod adresem wsk_ld = %i\n", *wsk_ld);


	printf("\n");
    system("PAUSE");
} 



// Definicja funkcji
int randomIntValue(int lowerB, int upperB){
    return ((rand() % (upperB-lowerB+1)) + lowerB);
}

void cleverPrintTab(int t[], int s){
    int i;
    if(s <= 20){
        printf("{ ");
        for(i = 0; i < s; i++){
            printf("%i ", t[i]);
        }
        printf("}\n");    
    }
    else{
        printf("{ ");
        for(i = 0; i < 10; i++){
            printf("%i ", t[i]);
        }
        printf("... ");    
        for(i = s-10; i < s; i++){
            printf("%i ", t[i]);
        }        
        printf("}\n");       
    }
}


void fillTab(int t[], int s, int minValue, int maxValue){
    int i;
    for(i = 0; i < s; i++){
        t[i] = randomIntValue(minValue, maxValue);
    }
}

