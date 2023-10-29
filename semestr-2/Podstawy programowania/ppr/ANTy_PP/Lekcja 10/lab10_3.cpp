#include"stdio.h"
#include"stdlib.h"
#include"math.h"

struct element{
	int dana;
	struct element *next;
};

void wstaw(struct element **l, int d);
void wypisz(struct element *h);
void doczep(struct element **l, int d);
void usunListe(struct element **l);

main(){

    struct element *lista = NULL;
    int wart,i, ile;

    printf("Podaj liczbe elementow do wstawienia:");
    scanf("%i", &ile);

	printf("Wstawiam do listy...\n");
	for(i = 0; i < ile; i++){
       printf("Podaj dane %i :",i+1);
       scanf("%i", &wart);
       wstaw(&lista,wart);
    }

	printf("Podane informacje:\n");
    printf("--------------------------------------\n");
	wypisz(lista);
    printf("\n--------------------------------------\n");

	printf("Niszcze liste\n");
	usunListe(&lista);
	usunListe(&lista);
	
	printf("Doczepiam do listy...\n");
    for(i = 0; i < ile; i++){
       printf("Podaj dane %i :",i+1);
       scanf("%i", &wart);
       doczep(&lista,wart);
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


void wypisz(struct element *h){
	struct element * wsk;

 	printf("{ ");
	for(wsk = h; wsk; wsk = (*wsk).next){
        printf("%i ", (*wsk).dana);
    }
 	printf("}\n");
};

void doczep(struct element **l, int d){
    if(*l == NULL){
        wstaw(l, d);
        return;
    }
    
    // Znajdz ostatni element
	struct element * wsk;
	for(wsk = *l; wsk->next; wsk = (*wsk).next);
	
	// Wstaw za ostatnim elementem
	struct element * nowy;
    nowy = (struct element *) malloc(sizeof(struct element));
    if(nowy == NULL){
      printf("Not enough memory.\n");
      exit( -1);
    }

    (*nowy).next = NULL;
    (*nowy).dana = d;
    wsk->next = nowy;
};

void usunListe(struct element **l){
    element *wsk = *l;
	while(wsk){
        *l = wsk->next;
        free(wsk);
        wsk = *l;
    };
};

