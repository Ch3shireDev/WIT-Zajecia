#include<stdio.h>
#include<stdlib.h>
#include<time.h>

#define SIZE 20
// Prototyp funkcji
int randomIntValue(int lowerB, int upperB);
void printTab(int t[], int s);
void losujTab(int t[], int s, int minValue, int maxValue);

void main(){
    // Inicjacja generatora liczb losowych
    srand((unsigned) time(NULL));

    int tabA[SIZE];
    printf("Program operuje na tablicach\n");
    printf("----------------------------\n");
	printf("\n");
	
	int a, b, value;
    printf("Losuje zawartosc tablice:\n");
	printf("Podaj dolna granice zakresu : ");
	scanf("%i", &a);
	printf("Podaj gorna granice zakresu : ");
	scanf("%i", &b);
    losujTab(tabA, SIZE, a, b);	
	printf("\n");

    printf("Wypisuje tablice:\n");
	printTab(tabA, SIZE);
	printf("\n");
	
	printf("\n");
    system("PAUSE");
}


// Definicja funkcji
int randomIntValue(int lowerB, int upperB){

    return ((rand() % (upperB-lowerB+1)) + lowerB);
}

void printTab(int t[], int s){
    int i;
    printf("{ ");
    for(i = 0; i < s; i++){
        printf("%i ", t[i]);
    }
    printf("}\n");    
};


void losujTab(int t[], int s, int minValue, int maxValue){
    int i;
    for(i = 0; i < s; i++){
        t[i] = randomIntValue(minValue, maxValue);
    }
}
