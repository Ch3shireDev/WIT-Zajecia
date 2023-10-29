#include<stdio.h>
#include<stdlib.h>
#include<time.h>

#define REPEAT 2000000
#define SIZEX 100
#define SIZEY 100

// Prototyp funkcji
void fillTab2D(int t[SIZEX][SIZEY], int sX, int sY);
void printTab2D(int t[SIZEX][SIZEY], int sX, int sY);
int findWayZ(int t[SIZEX][SIZEY], int sX, int sY);
int findWayR(int t[SIZEX][SIZEY], int sX, int sY, int pozX, int pozY);
int findWayD(int t[SIZEX][SIZEY], int sX, int sY);

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

    int kosztZ;
    printf("Szukam drogi metoda zachlanna... ");
    start=clock();
    kosztZ = findWayZ(tab, SIZEX, SIZEY);
    stop=clock();
    printf(" zrobione w %f s \n",(float)(stop-start)/CLK_TCK);
    printf("Znaleziona droga ma koszt = %i \n", kosztZ );

 /*  int kosztR;
    printf("Szukam drogi metoda rekurencyjna... ");
    start=clock();
    kosztR = findWayR(tab, SIZEX, SIZEY, 0, 0);
    stop=clock();
    printf(" zrobione w %f s \n",(float)(stop-start)/CLK_TCK);
    printf("Znaleziona droga ma koszt = %i \n", kosztR );
*/
    int kosztD;
    printf("Szukam drogi metoda dynamiczna... ");
    start=clock();
    kosztD = findWayD(tab, SIZEX, SIZEY);
    stop=clock();
    printf(" zrobione w %f s \n",(float)(stop-start)/CLK_TCK);
    printf("Znaleziona droga ma koszt = %i \n", kosztD );
    
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

int findWayZ(int t[SIZEX][SIZEY], int sX, int sY){
   int i = 0, j = 0, c1, c2, c3;
   int cost = t[0][0];
   do{
     if(i == sX-1){
        cost += t[i][++j];
     }
     else if(j == sY-1){
        cost += t[++i][j];
     }
     else{
        c1 = t[i][j+1];
        c2 = t[i+1][j];

       if(c1 < c2){
          cost += c1;
          j++;
       }
       else{
          cost += c2;
          i++;
       }
     }
   }while( (i != sX-1) || (j != sY-1));
   return cost;
}

int findWayR(int t[SIZEX][SIZEY], int sX, int sY, int pozX, int pozY){
   int c1, c2;

   int cost = t[pozX][pozY];


   if((pozX == sX-1) && (pozY == sY-1)){
      return cost;
   }

   if(pozX == sX-1){
      cost += findWayR(t, sX, sY, pozX,pozY+1);
      return cost;
   }
   else if(pozY == sY-1){
      cost += findWayR(t, sX, sY, pozX+1,pozY);
      return cost;
   }
   else{
      c1 = findWayR(t, sX, sY, pozX,pozY+1);
      c2 = findWayR(t, sX, sY, pozX+1,pozY);

      if(c1 < c2){
        cost += c1;
      }
      else{
         cost += c2;
      }
   }
   return cost;
}

int findWayD(int t[SIZEX][SIZEY], int sX, int sY){
   int i, j, c1, c2;

   for(i = 1; i < sX; i++){
      t[i][0] += t[i-1][0];
   }
   for(j = 1; j < sY; j++){
      t[0][j] += t[0][j-1];
   }


   for(i = 1; i < sX; i++){
      for(j = 1; j < sY; j++){
         c1 = t[i][j-1];
         c2 = t[i-1][j];

        if(c1 < c2){
           t[i][j] += c1;
        }
        else{
           t[i][j] += c2;
        }
      }
   }
   return t[sX-1][sY-1];
}
