#include<stdio.h>
#include<stdlib.h>
#include<time.h>

#define SIZE 20
// Prototyp funkcji
int randomIntValue(int lowerB, int upperB);
void printTab(int t[], int s);

void main(){

    int tabA[SIZE];
    printf("Program operuje na tablicach\n");
    printf("----------------------------\n");
	printf("\n");
	
    printf("Wypisuje tablice:\n");
	printTab(tabA, SIZE);
	
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

