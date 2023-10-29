#include<stdio.h>
#include<stdlib.h>
#include<time.h>

#define SIZE 20

// Prototyp funkcji
int randomIntValue(int lowerB, int upperB);

void printTab(int t[], int s);
void cleverPrintTab(int t[], int s);
void printTableTail(int t[], int s);
void printTableHead(int t[], int s);


void losujTab(int t[], int s, int minValue, int maxValue);

int findMaxInTable(int t[], int s);
int findMinInTable(int t[], int s);

void simpleSortTable(int t[], int s);

// Funkcja scala tablice t1 i t2 i umiescza w t3


void main(){
    // Inicjacja generatora liczb losowych
    srand((unsigned) time(NULL));

    int tabA[SIZE];
    int tabB[SIZE];
    int tabC[SIZE];

    printf("Program operuje na tablicach\n");
    printf("----------------------------\n");
	printf("\n");
	
	int a, b, value;
    printf("Losuje zawartosc tablic:\n");
	printf("Podaj dolna granice zakresu : ");
	scanf("%i", &a);
	printf("Podaj gorna granice zakresu : ");
	scanf("%i", &b);
    losujTab(tabA, SIZE, a, b);	
    losujTab(tabB, SIZE, a, b);	
        losujTab(tabC, SIZE, a, b);	
	printf("\n");

    printf("Wypisuje tablice A:\n");
	cleverPrintTab(tabA, SIZE);
	printf("\n");
	
    printf("Wypisuje tablice B:\n");
	cleverPrintTab(tabB, SIZE);
	printf("\n");

    printf("Wypisuje tablice C:\n");
	cleverPrintTab(tabC, SIZE);
	printf("\n");

    printf("Sortowanie tablicy A\n");
    simpleSortTable(tabA, SIZE);
    printf("Wypisuje tablice A:\n");
	cleverPrintTab(tabA, SIZE);
	printf("\n");
	
    printf("Sortowanie tablicy B\n");
    simpleSortTable(tabB, SIZE);
    printf("Wypisuje tablice B:\n");
	cleverPrintTab(tabB, SIZE);
	printf("\n");
	

    printf("Sortowanie tablicy C\n");
    simpleSortTable(tabC, SIZE);
    printf("Wypisuje tablice C:\n");
	cleverPrintTab(tabC, SIZE);
	printf("\n");

  	int max = findMaxInTable(tabA, SIZE);
    printf("Wartosc MAX w tablicy : %i\n", max);
	printf("\n");
    
	printf("\n");
    system("PAUSE");
}


// Definicja funkcji
int randomIntValue(int lowerB, int upperB){
    return ((rand() % (upperB-lowerB+1)) + lowerB);
}

void printTab(int t[], int s) {
printf("\n");

for(int i=0;i<s;i++) { printf("%i ", t[i]); }

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

void simpleSortTable(int t[], int s){
    int i, j, min, minIndex, tmp;
    for(i = 0; i < s; i++){
        min = t[i];
        minIndex = i;
        for(j = i + 1; j < s; j++){
            if(min > t[j]){
                min = t[j];
                minIndex = j;
            }
        }
        if(minIndex != i){
            tmp = t[i];
            t[i] = t[minIndex];
            t[minIndex] = tmp;
        }
    }
}




