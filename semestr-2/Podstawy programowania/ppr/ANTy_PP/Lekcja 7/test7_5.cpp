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
    int *wsk_i = &tab[0];
    printf("Zawartosc wsk_i = %p\n", wsk_i);
    printf("Zawartosc pamieci pod adresem wsk_i = %i\n", *wsk_i);

	printf("\n");
    system("PAUSE");

    printf("Ustawiam wskaznik na kolejny element tablicy:\n");
    wsk_i ++;
    printf("Zawartosc wsk_i = %p\n", wsk_i);
    printf("Zawartosc pamieci pod adresem wsk_i = %i\n", *wsk_i);

    printf("Cofam wskaznik na pierwszy element tablicy:\n");
    wsk_i --;
    printf("Zawartosc wsk_i = %p\n", wsk_i);
    printf("Zawartosc pamieci pod adresem wsk_i = %i\n", *wsk_i);


	printf("\n");
    system("PAUSE");

/*
    printf("To samo nie zadziala na zmiennej 'tab'\n");
    tab ++;
    printf("Zawartosc wsk_i = %p\n", tab);
    printf("Zawartosc pamieci pod adresem wsk_i = %i\n", *tab);
*/
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

