#include<stdio.h>
#include<stdlib.h>
#include<time.h>

#define REPEAT 2000000
#define SIZEX 5
#define SIZEY 5

// Prototyp funkcji
void fillTab2D(int t[SIZEX][SIZEY], int sX, int sY);
void printTab2D(int t[SIZEX][SIZEY], int sX, int sY);

void main(){
    // Inicjacja generatora liczb losowych
    srand((unsigned) time(NULL));

	clock_t start,stop;

    printf("Operowanie na tablicach 2D\n");
    printf("--------------------------\n");
	printf("\n");

    int tab[SIZEX][SIZEY];
    	
    printf("Wypelniam losowa tablice... ");
    start=clock();
    fillTab2D(tab, SIZEX, SIZEY);
    stop=clock();
    printf(" zrobione w %f s \n",(float)(stop-start)/CLK_TCK);
	
    printf("Wypisuje tablice...\n ");
    printTab2D(tab, SIZEX, SIZEY);


    
	printf("\n");
    system("PAUSE");
}

void fillTab2D(int t[SIZEX][SIZEY], int sX, int sY){
   int i, j;
   for(i = 0; i < sX; i++){
      for(j = 0; j < sY; j++){
         t[i][j] = rand() % 10;
      }
   }
}

void printTab2D(int t[SIZEX][SIZEY], int sX, int sY){
   int i, j;
   printf("\n");
   for(i = 0; i < sX; i++){
      for(j = 0; j < sY; j++){
         printf("%i ",t[i][j]);
      }
      printf("\n");
   }
}

