#include"stdio.h"
#include"stdlib.h"
#include"math.h"

struct element{
	int dana;
	struct element *lewy, *prawy;
};

void wstaw(struct element **d, int w);
void wypisz(struct element *d);
void wypiszNL(struct element *d);
void wypiszNP(struct element *d);

main(){

	struct element *drzewo = NULL;
   int wart,i, ile;

   printf("Wypelniam drzewo BST...\n");

   printf("Podaj liczbe elementow do wstawienia:");
   scanf("%i", &ile);

	for(i = 0; i < ile; i++){
      printf("Podaj dane %i :",i+1);
      scanf("%i", &wart);
      wstaw(&drzewo,wart);
   }

	printf("Podane informacje:\n");
   printf("--------------------------------------\n");
	wypisz(drzewo);
   printf("\n--------------------------------------\n");

	printf("Posortowane rosnaco:\n");
   printf("--------------------------------------\n");
	wypiszNL(drzewo);
   printf("\n--------------------------------------\n");

	printf("Posortowane malejaco:\n");
   printf("--------------------------------------\n");
	wypiszNP(drzewo);
   printf("\n--------------------------------------\n");

   system("PAUSE");
}

void wstaw(struct element **d, int w){
   struct element * nowy;
   struct element * biezacy = *d;

   nowy = (struct element *) malloc(sizeof(struct element));
   if(nowy == NULL){
      printf("Not enough memory.\n");
      exit( -1);
   }

   (*nowy).lewy = NULL;
   (*nowy).prawy = NULL;
   (*nowy).dana = w;

   if(*d == NULL){
   	*d = nowy;
      return;
   }


   do{
   	if((*biezacy).dana < w){
      	if((*biezacy).prawy == NULL){
         	(*biezacy).prawy = nowy;
            return;
         }
         else{
         	biezacy = (*biezacy).prawy;
         }
      }
   	else{
      	if((*biezacy).lewy == NULL){
         	(*biezacy).lewy = nowy;
            return;
         }
         else{
         	biezacy = (*biezacy).lewy;
         }
      }

   }while(1);
};

void wypisz(struct element *d){
	if(d == NULL) return;
   printf("%i ", (*d).dana);
   wypisz((*d).lewy);
   wypisz((*d).prawy);
};

void wypiszNL(struct element *d){
	if(d == NULL) return;
   wypiszNL((*d).lewy);
   printf("%i ", (*d).dana);
   wypiszNL((*d).prawy);
};

void wypiszNP(struct element *d){
	if(d == NULL) return;
   wypiszNP((*d).prawy);
   printf("%i ", (*d).dana);
   wypiszNP((*d).lewy);
};

