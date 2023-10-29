#include<stdio.h>
#include<stdlib.h>
#include<time.h>

// Prototyp funkcji
int randomIntValue(int lowerB, int upperB);

void main(){

    srand((unsigned) time(NULL));
    
    printf("Program losuje liczbe z podanego zakresu\n");
    printf("----------------------------------------\n");
	printf("\n");
	
	int a, b, value;
	printf("Podaj dolna granice zakresu : ");
	scanf("%i", &a);
	printf("Podaj gorna granice zakresu : ");
	scanf("%i", &b);
	
    value = randomIntValue(a,b);
    printf("Wylosowana liczba : %i\n", value);

	printf("\n");
    system("PAUSE");
}


// Definicja funkcji
int randomIntValue(int lowerB, int upperB){
    return ((rand() % (upperB-lowerB+1)) + lowerB);
}
