#include<stdio.h>
#include<stdlib.h>
#include<time.h>

#define SIZE 20
// Prototyp funkcji
int randomIntValue(int lowerB, int upperB);

void printTab(int t[], int s);
void printTableTail(int t[], int s);
void printTableHead(int t[], int s);

void losujTab(int t[], int s, int minValue, int maxValue);

int findMaxInTable(int t[], int s);
int findMinInTable(int t[], int s);


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
	
    printf("Wypisuje glowe tablicy:\n");
	printTableHead(tabA, SIZE);
	printf("\n");

    printf("Wypisuje ogon tablicy:\n");
	printTableTail(tabA, SIZE);
	printf("\n");

	int max = findMaxInTable(tabA, SIZE);
    printf("Wartosc MAX w tablicy : %i\n", max);
	printf("\n");

	int min = findMinInTable(tabA, SIZE);
    printf("Wartosc MIN w tablicy : %i\n", min);
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

void printTableHead(int t[], int s){
   // Wypisanie tablicy
   int i;
   if (s > 10) s = 10;
   printf("{ ");
   for(i = 0; i < s; i++){
      printf("%i ", t[i]);
   }
   printf("...}\n");
}

void printTableTail(int t[], int s){
   // Wypisanie tablicy
   int i;
   int tail;
   if (s > 10){
      tail = 10;
   }
   else{
      tail = s;
   }
   printf("{... ");
   for(i = s - tail; i < s; i++){
      printf("%i ", t[i]);
   }
   printf("}\n");
}

int findMaxInTable(int t[], int s){
   int i, max = t[0];
   for(i = 1; i < s; i++){
        if(max < t[i]) max = t[i];   
   }
   return max;
};

int findMinInTable(int t[], int s){
   int i, min = t[0];
   for(i = 1; i < s; i++){
        if(min > t[i]) min = t[i];   
   }
   return min;
}
