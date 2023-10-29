/*porównaæ czas dzia³ania funkcji znajduj¹cej liczbê elementów wiêkszych od 
zadanego w tablicy, liœcie i drzewie - na 3, na drzewie kombinacje - odpowiedŸ w jak
najkrótszym czasie na drzewie BST - 2) na lepsz¹ ocenê - uzupe³niæ wêze³ o dodatkowe 
informacje - na 4, ¿eby dane z tymi samymi danymi maia³y byæ w jednym wêŸle - ile jest
elementów o tej samej wartoœci w jednym wêŸle i dodaæ pola - ile jest elementów w jednym
poddrzewie a ile w drugim poddrzewie - to do przeszukiwania

porównaæ czas sortowania b¹belkowego danych w tablicy, liœcie i drzewa( sortowanie
przez obejœcie) - na 3 
4) na 5 - w liœcie sortowanie ma polegaæ na przestawianiu wskaŸników, a nie danych
+ modyfikacja drzewa, aby (z komentarzami, gdzie s¹ modyfikacje)
wszêdzie floaty
*/
#include<stdio.h>
#include<stdlib.h>
#include<time.h>
#include<strings.h>

#define SIZE 20
struct rekord{
	float dana;
	int left, right;
	int ile;
	struct rekord *lewy, *prawy;
};

struct element{
	float dana;
	struct element *next;
};

// Prototyp funkcji (INACZEJ !!!!!!!!!!!!!!!!!!!!!!!!!)
float * createTabInt(int s);
void cleverPrintTabInt(float *t, int s);
void fillTabInt(float *t, int s, int minValue, int maxValue);
void sortujbabelkowo(float tablica[],int rozmiar);
int wyszukajTab(float t[],int s,float element);
void wstaw(struct element **l, int d);
void BLAD();
void usunListe(element**l);
int znajdz(element *l,float wart);
float randomIntValue(int lowerB, int upperB);
void wstawR(struct rekord **d, int w, int toSamo);
void usunR(struct rekord **d);
void wypisz(struct rekord *d);
void usunElement(element **l,int ktory,int wartosc);
void wstawZa(element **l,int numer,int wart);
void SortujListe(element **l,int ile);
void wypiszListe(struct element *h);
int znajdzBST(rekord *d,float element, int A);
void wypiszNL(struct rekord *d);

void main(){
    // Inicjacja generatora liczb losowych
    srand((unsigned) time(NULL));
	clock_t start,stop;
    struct element *lista = NULL;
	struct rekord *drzewo = NULL;

    printf("Tworzenie tablic dynamicznie\n");
    printf("--------------------------\n");
	printf("\n");

    float *tab;
    int i,size,a;
    printf("Podaj rozmiar tablicy : ");
    scanf("%i", &size);
    
    printf("Tworze tablice:\n");
    tab = createTabInt(size);

    printf("Losuje zawartosc tablicy...\n");
    start=clock();
    fillTabInt(tab, size, 0, 100);	
    stop=clock();
    printf(" zrobione w %f s \n",(float)(stop-start)/CLK_TCK);
	printf("\n");

    float el;
    float czy;  // czy znalezionno element i ile ich jest
    fflush(stdin);printf("Podaj element do wyszukania: ");scanf("%f",&el);

    printf("Wyszukiwanie w tablicy...\n");
    start=clock();
    czy=wyszukajTab(tab, size, el);	
    stop=clock();
    printf("Znalezioniono %f elementów wiêkszych\n",czy);
    printf(" zrobione w %f s \n",(float)(stop-start)/CLK_TCK);
	printf("\n");

    for(i = 0; i < size; i++){
        wstaw(&lista,randomIntValue(0,100));
    }
    printf("Wyszukiwanie w liœcie...\n");
    start=clock();
    czy=znajdz(lista,el);	
    stop=clock();
    printf("Znalezioniono %f elementów wiêkszych\n",czy);
    printf(" zrobione w %f s \n",(float)(stop-start)/CLK_TCK);
	printf("\n");

	
 
    printf("Wyszukiwanie w drzewie...\n");
	for(i = 0; i < size; i++){

      wstawR(&drzewo,randomIntValue(0,100),0);
   }

    start=clock();
    czy=znajdzBST(drzewo,el,0);	 //raz dzia³a raz nie dzia³a:( czasem zadzia³a
    stop=clock();
    printf("Znalezioniono %f elementów wiêkszych\n",czy);
    printf(" zrobione w %f s \n",(float)(stop-start)/CLK_TCK);
	printf("\n");

    printf("Sortowanie babelkowe\n");
    start=clock();
    for(a=0;a<1000;a++)
    {
    sortujbabelkowo(tab,size);
    }
    stop=clock();
    printf(" zrobione w %f s \n",(float)(stop-start)/CLK_TCK);

    printf("Sortowanie listy\n");
    start=clock();
//    for(a=0;a<1;a++)
    {
    SortujListe(&lista,size);
    }
    stop=clock();
    printf(" zrobione w %f s \n",(float)(stop-start)/CLK_TCK);
    rekord *root = NULL;
    
    float *C;
    
    C=createTabInt(SIZE);  
    fillTabInt(C,SIZE,0,100);
    
    printf("Sortowanie drzewiaste\n");
    start=clock();
    for(i=0;i<size;i++)
      wstawR(&root,C[i],0);
    for(a=0;a<1000;a++)
     {

    wypisz(root);
     }
    stop=clock();
    printf(" zrobione w %f s \n",(float)(stop-start)/CLK_TCK);     

    printf("Wypisuje tablice A:\n");
	cleverPrintTabInt(tab, size);
	printf("\n");
 
    printf("Wypisuje liste :\n");
	wypiszListe(lista);
	printf("\n");    
    printf("Usuwam tablice:\n");
    free(tab);

    printf("Usuwam drzewo BST...\n");
    usunR(&drzewo);
	printf("\n");
    system("PAUSE");
} 



// Definicja funkcji
float randomIntValue(int lowerB, int upperB){   // musi byæ int bo dzielenie % jest tylko dla intów
    return ((rand() % (upperB-lowerB+1)) + lowerB);
}

void cleverPrintTabInt(float t[], int s){
    int i;
    if(s <= 20){
        printf("{ ");
        for(i = 0; i < s; i++){
            printf("%f ", t[i]);
        }
        printf("}\n");    
    }
    else{
        printf("{ ");
        for(i = 0; i < 10; i++){
            printf("%f ", t[i]);
        }
        printf("... ");    
        for(i = s-10; i < s; i++){
            printf("%f ", t[i]);
        }        
        printf("}\n");       
    }
}


void fillTabInt(float *t, int s, int minValue, int maxValue){
    int i;
    for(i = 0; i < s; i++){
        t[i] = randomIntValue(minValue, maxValue);
    }
}

float * createTabInt(int s){
    float *t;
    //Tworze tablice;
    t = (float *)malloc(s * sizeof(float));
    if(t == NULL){
        printf("BLAD! Nie moge zaalokowac pamieci!\n");
        exit(-1);        
    }
    return t;
}

void sortujbabelkowo(float tab[],int rozmiar)
{
    int i,j;
    
    for (i=0;i<rozmiar;i++)
        for(j=rozmiar-1;j>i;j--)
              if (tab[j]<tab[j-1])
                {
                  tab[j]=tab[j]+tab[j-1];
                  tab[j-1]=tab[j]-tab[j-1];
                  tab[j]=tab[j]-tab[j-1];
                }
}

int wyszukajTab(float t[],int s,float element)
{
  int a=0;
  int b=0;
  
  while (a<s)
  {
    if (t[a] > element) b++;
    a++;
  }
  return b;
}

void BLAD()
{
  printf("\nBLAD ALOKACJI PAMIECI\n");
  system("pause");
  exit(-1);
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
void usunListe(element**l)
{
  element*wsk=*l;
  while(wsk)
  {
    *l=wsk->next;
    free(wsk);
    wsk=*l;
  }
}

int znajdz(element *l,float wart)
{
  element*wsk=l;
  int a=0;
  while(wsk)
  {
    if((wsk->dana)>wart)
        a++;
    wsk=wsk->next;
  }
  return a;
}

void wstawR(struct rekord **d, int w, int toSamo){
   struct rekord * nowy;

   nowy = (struct rekord *) malloc(sizeof(struct rekord));
   if(nowy == NULL){
      printf("Not enough memory.\n");
      exit( -1);
   }
   if (toSamo==1)
   {
    (*nowy).ile=(**d).ile++;
    (*nowy).left = 0;
    (*nowy).right = 0;
    (*nowy).dana = w;
   }
   
   (*nowy).lewy = NULL;
   (*nowy).prawy = NULL;
   (*nowy).left = 0;
   (*nowy).right = 0;
   (*nowy).dana = w;

   if(*d == NULL){
   	*d = nowy;
      return;
   }

  	if((**d).dana < w){
      wstawR( &((**d).prawy), w,0);
   }
   else if ((**d).dana >w) {
      wstawR( &((**d).lewy), w, 0);
   } else wstawR(&((**d).prawy), w,1);
   return;
   
};

void usunR(struct rekord **d){
   if(*d == NULL){
      return;
   }
   usunR( &((**d).prawy));
   usunR( &((**d).lewy));
   free(*d);
   *d = NULL;
   return;
}

void wypisz(struct rekord *d){
	if(d == NULL) return;
 //  printf(".");
   wypisz((*d).lewy);
   wypisz((*d).prawy);
};
void wstawZa(element **l,int numer, int wart)
{
    if(*l == NULL){
        wstaw(l, wart);
        return;
    }
    
    // Znajdz zadany element
	struct element * wsk;
	//for(wsk = *l; wsk->next; wsk = (*wsk).next);
	wsk=*l;
    int a=0;
	while((wsk->next!=NULL)&&(a<numer))
	{
	  wsk=wsk->next;
	  a++;
	}
	struct element *nastepny=wsk->next;
	
	// Wstaw za zadanym elementem
	struct element * nowy;
    nowy = (struct element *) malloc(sizeof(struct element));
    if(nowy == NULL){
      printf("Not enough memory.\n");
      exit( -1);
    }

    (*nowy).next = nastepny;
    (*nowy).dana = wart;
    wsk->next = nowy;
  
}
void usunElement(element **l,int ktory,int wartosc)
{
/*void usunListe(struct element **l){
    element *wsk = *l;
	while(wsk){
        *l = wsk->next;
        free(wsk);
        wsk = *l;
    };
*/
  int a=0;
  element *wsk= *l;
  element *poprzedni=*l;
  if (wartosc==NULL)
  {
    while ((wsk!=NULL)&&(a<ktory))
    { 
      if(a==ktory-2) poprzedni=wsk->next;
      wsk=wsk->next;
      a++;
    };
    element *nastepny=wsk->next;
    free(wsk);
    poprzedni->next=nastepny;
//    wsk->next=nastepny;
  }
  else
  {
    while ((wsk!=NULL)&&(wsk->dana!=wartosc))
    {
      wsk=wsk->next;
      if (wsk->next->dana==wartosc)
      {
        poprzedni=wsk;
        wsk=wsk->next;
        break;
      }
      a++;
    };
    element *nastepny=wsk->next;
    free(wsk);
    poprzedni->next=nastepny;
  }
}

void wstawPrzed(element **l,int numer, int wart)
{
    if(*l == NULL){
        wstaw(l, wart);
        return;
    }
    
    // Znajdz zadany element
	struct element * wsk;
	//for(wsk = *l; wsk->next; wsk = (*wsk).next);
	wsk=*l;
    int a=0;
	while((wsk->next!=NULL)&&(a<numer-1))
	{
	  wsk=wsk->next;
	  a++;
	}
    
    struct element *poprzedni=wsk->next;	
	// Wstaw przed zadanym elementem
	struct element * nowy;
    nowy = (struct element *) malloc(sizeof(struct element));
    if(nowy == NULL){
      printf("Not enough memory.\n");
      exit( -1);
    }

    (*nowy).next = poprzedni;
    (*nowy).dana = wart;
    wsk->next = nowy;
  
}

void SortujListe(element **l,int ile)
{
    if(*l == NULL){
        return;
    }
    
    // Znajdz zadany element
	struct element * wsk;
	int pom;
	//for(wsk = *l; wsk->next; wsk = (*wsk).next);
	wsk=*l;
	int i=ile;
	for(i=0;i<ile;i++)
	{while((wsk!=NULL))
	 {
	  if ((wsk->dana)>(wsk->next->dana))
	  {
	     pom=wsk->dana;
         usunElement(&wsk,NULL,wsk->dana);    //usuwa bie¿¹cy element
	     wstawPrzed(l,0,pom);                  //wstawia wartoœæ na pocz¹tek

	  }
      wsk=wsk->next;
      i--;
     }
	//if (wsk==NULL) wsk=*l;
	}
}
void wypiszListe(struct element *h){
	struct element * wsk;

 	printf("{ ");
	for(wsk = h; wsk; wsk = (*wsk).next){
        printf("%i ", (*wsk).dana);
    }
 	printf("}\n");
};

int znajdzBST(rekord *d,float element, int A)
{  
   int a=A;
   if(d == NULL) return a;
   a=znajdzBST((*d).lewy,element,a);
   if( ((*d).dana)>element) a++;
   a=znajdzBST((*d).prawy,element,a);

   return a;
}
