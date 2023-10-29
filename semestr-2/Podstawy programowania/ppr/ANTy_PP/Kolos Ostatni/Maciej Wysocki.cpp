/*

    Kolokwium -> Podstawy Programowania
    © Maciej Wysocki

 1) ile elementow > od zadanego (tab, list, tree)
 2) modyfikacja drzewa
 3) sortuj (tab, list, tree)
 4) zamiana wskaznikow

*/

#include<stdio.h>
#include<stdlib.h>
#include<math.h>
#include<time.h>
#include<conio.h>

struct element {
	float dana;
	struct element *next; // Lista
	struct element *lewy, *prawy; // Drzewko
};

void wypiszTree(struct element *d);
void wstawTree(struct element **d, float w);
void wstaw(struct element **l, float d);
void wypisz(struct element *h);
void doczep(struct element **l, float d);
void usunListe(struct element **l);
void wypiszTab(float *t,int s);
void wypiszSortTree(struct element *d);
void bombelkiTab(float *tab, int s);
int ileJestTab(float *t,int s, float sercz);
int ileJestList(struct element *h,float sercz);
void wypiszSortList(struct element *h);
main() {

srand((unsigned) time(NULL));
clock_t start,stop;

struct element *lista=NULL;
struct element *drzewo = NULL;
float wart;
int i, ile;

printf("\a\n\t*** Witaj na kolokwium ***\n\nPodaj liczbe elementow do wstawienia : ");        scanf("%i",&ile);

    float tablica[ile];

    printf("\nWstawiam do listy...\n");
    printf("Wypelniam tablice...\n");
    printf("Wypelniam drzewo BST...\n\n");
    
	for(i=0; i<ile; i++) {

    wart=rand();        // Losowa wartosc float
    wstaw(&lista,wart); // Wstawianie do listy
    wart=rand();
    tablica[i]=wart;    // Wstawianie do tabliczki
    wart=rand();
    wstawTree(&drzewo,wart); // Wstawianie do BSE
    }

    printf("Wypisuje liste...\n");
	wypisz(lista);
    printf("\nWypisuje tablice...\n");
    wypiszTab(tablica,ile);
    printf("\nWypisuje drzewo BST...\n");
    wypiszTree(drzewo);

    printf("\nSortuje i wypisuje..."); // Sortowanie
    start=clock();
//  printf("\nListe...\n");
    
    printf("\nTablice...\n");
    bombelkiTab(tablica,ile);
    wypiszTab(tablica,ile);

    printf("\nDrzewo BST...\n");

    wypiszSortTree(drzewo);
    stop=clock();
    printf("\nZrobione w %f s\n",(float)(stop-start)/CLK_TCK);
    
    float szuka;
    printf("\nProgram sprawdzi ilosc elementow wiekszych od...\nPodaj liczbe : "); scanf("%f",&szuka);

    printf("\nW tablicy...\n");
    printf("Znaleziono %i elementow wiekszych od %f",ileJestTab(tablica,ile,szuka),szuka);
    
    printf("\n\nW liscie...\n");
    printf("Znaleziono %i elementow wiekszych od %f",ileJestList(lista,szuka),szuka);

printf("\n\nAby zakonczyc program nacisnij dowolny klawisz...");
getche();
}

void wypiszSortList(struct element *h) { // Wypisuje liste posortowana
	struct element * wsk;

	float temp=(*wsk).dana;
	
	for(wsk=h; wsk; wsk=(*wsk).next) {
//	if((*wsk).next<(*wsk).dana) { temp=(*wsk).dana; (*wsk).dana=(*wsk).next; (*wsk).next=temp; }

    }
}

int ileJestList(struct element *h,float sercz) { int resulL=0; // Liczy ilosc el. w liscie wiekszych od sercz
struct element * wsk;

    for(wsk=h; wsk; wsk=(*wsk).next) {
	if((*wsk).dana>sercz) { resulL++; }
    }
    
return resulL;
}


int ileJestTab(float *t,int s,float s3) { int resulT=0; // Liczy ilosc el. w tabliczce wiekszych od s3
for(int i=0; i<s; i++) {
if(t[i]>s3) { resulT++; }
}
return resulT;
}

void bombelkiTab(float *tab,int s) { s--; // Sortowanie tabliczki bombelkami
float tmp;
for(int i=0; i<s; i++) {
    for(int j=0; j<s; j++) {
    
        if(tab[j+1]<tab[j]) {
        tmp=tab[j];
        tab[j]=tab[j+1];
        tab[j+1]=tmp;
        }
        
    }
}
}

void wypiszTab(float *t,int s) {
for(int i=0; i<s; i++) { printf("Array[%i]=>%f\n",i,t[i]); }
}

void wypiszSortTree(struct element *d) { // Wypisuje drzewko posortowane rosnaco
if(d==NULL) return;

   wypiszSortTree((*d).lewy);
   printf("%f\n",(*d).dana);
   wypiszSortTree((*d).prawy);
};

void wypiszTree(struct element *d){ // Wypisuje drzewo
if(d==NULL) return;

   printf("%f\n",(*d).dana);
   wypiszTree((*d).lewy);
   wypiszTree((*d).prawy);
}

void wstawTree(struct element **d, float w){ // Wypelnia drzewo listkami itp.
   struct element * nowy;
   struct element * biezacy = *d;

   nowy=(struct element *)malloc(sizeof(struct element));
   if(nowy == NULL){
      printf("Za malo pamieci... Kup sobie lepszy komputer ;)");
      exit(0);
   }

   (*nowy).lewy = NULL;
   (*nowy).prawy = NULL;
   (*nowy).dana = w;

   if(*d == NULL){
   	*d = nowy;
      return;
   }


   do {
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

   } while(1);
}

void wstaw(struct element **l, float d){ // Wypelnia liste
	struct element * nowy;
    nowy = (struct element *) malloc(sizeof(struct element));
    if(nowy == NULL){
      printf("Not enough memory.\n");
      exit(0);
    }

    (*nowy).next = *l;
    (*nowy).dana = d;
    *l = nowy;
}


void wypisz(struct element *h){ // Wypisuje liste
	struct element * wsk;

	for(wsk = h; wsk; wsk = (*wsk).next){
        printf("%f\n", (*wsk).dana);
    }
}

/////////////////////////////////// EOT ///////////////////////////////////

void doczep(struct element **l, float d){
    if(*l == NULL){
        wstaw(l, d);
        return;
    }
	struct element * wsk;
	for(wsk = *l; wsk->next; wsk = (*wsk).next);
	
	struct element * nowy;
    nowy = (struct element *) malloc(sizeof(struct element));
    if(nowy == NULL){
      printf("Not enough memory.\n");
      exit( -1);
    }

    (*nowy).next = NULL;
    (*nowy).dana = d;
    wsk->next = nowy;
}

void usunListe(struct element **l){
    element *wsk = *l;
	while(wsk) {
        *l = wsk->next;
        free(wsk);
        wsk = *l;
    }
}


