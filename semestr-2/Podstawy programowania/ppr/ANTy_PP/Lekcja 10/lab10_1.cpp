#include"stdio.h"
#include"stdlib.h"
#include"math.h"

struct element{
	int dana;
	struct element *next;
};

void wstaw(struct element **l, int d);
void wypisz(struct element *l);

main(){

    struct element *lista = NULL;
    int wart,i, ile;

    printf("Podaj liczbe elementow do wstawienia:");
    scanf("%i", &ile);

	 for(i = 0; i < ile; i++){
        printf("Podaj dane %i :",i+1);
        scanf("%i", &wart);
        wstaw(&lista,wart);
     }

	printf("Podane informacje:\n");
    printf("--------------------------------------\n");
	wypisz(lista);
    printf("\n--------------------------------------\n");
    
    system("PAUSE");
}

void wstaw(struct element **l, int d){
	struct element * nowy;
    nowy = (struct element *) malloc(sizeof(struct element));
    if(nowy == NULL){
      printf("Not enough memory.\n");
      exit( -1);
    }

    (*nowy).next = *l;
    (*nowy).dana = d;
    *l = nowy;
};


void wypisz(struct element *l){
	struct element * wsk;

 	printf("{ ");
	for(wsk = l; wsk; wsk = (*wsk).next){
        printf("%i ", (*wsk).dana);
    }
 	printf("}\n");
};

