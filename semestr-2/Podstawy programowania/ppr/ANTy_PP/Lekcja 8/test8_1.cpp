// programik tworzy tablice o zadanym rozmiarze, wyupelnia los
// wypisze na ekran sprytnie
// f. sortowala nasza tab w najlepszy sposob, sort by scalanie

#include<stdio.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>
#define SIZE 20

void cleverPrintTab(int *t, int s);
void fillTab(int *t, int s, int minValue, int maxValue);
int *createTab(int s);
void zamien(int *a, int *b);
void BubbleSort(int tab[], int n);
void rekMergeSort(int tab[], int s);
void polacz(int _n[], int a, int _m[], int b, int _t[], int c);

void main() {
    // Inicjacja generatora liczb losowych
    srand((unsigned) time(NULL));
	clock_t start,stop;


    printf("Tworzenie tablic dynamicznie\n");
    printf("--------------------------\n");
	printf("\n");

    int *tab;
    int size;
    printf("Podaj rozmiar tablicy : ");
    scanf("%i", &size);
    
    printf("Tworze tablice:\n");
  
tab=createTab(size);


   /* tab = (int *)malloc(size * sizeof(int));
    if(tab == NULL){
        printf("BLAD! Nie mge zaalokowac pamieci!\n");
        exit(0);        
    }
*/
    printf("Losuje zawartosc tablicy...\n");
    start=clock();
    for(int i=0; i<990; i++) {
    fillTab(tab, size, 1, 9);	
    }
    stop=clock();
    printf(" zrobione w %f s \n",(float)(stop-start)/CLK_TCK);
	printf("\n");

    printf("Wypisuje tablice A:\n");
	cleverPrintTab(tab, size);
	printf("\n");
	
//    printf("Sortuje tablice...\n");
    start=clock();
//BubbleSort(tab,size);
    stop=clock();
//    printf(" zrobione w %f s \n",(float)(stop-start)/CLK_TCK);
	printf("\n");
	
//	    printf("Wypisuje posortowana tablice A:\n");
//	cleverPrintTab(tab, size);
	printf("\n");
	
/*
    printf("Zmieniam rozmiar tablicy:\n");
    int sizeNew;
    printf("Podaj nowy rozmiar tablicy : ");
    scanf("%i", &sizeNew);
    //Tworze nowa tablice;
    int *tabTmp = (int *)malloc(sizeNew * sizeof(int));
    if(tab == NULL){
        printf("BLAD! Nie mge zaalokowac pamieci!\n");
        exit(-1);        
    }
    //Kopiuje co sie da ze starej;
    int sizeTmp = (size < sizeNew)? size : sizeNew;
    for(int i = 0; i < sizeTmp; i++)tabTmp[i] = tab[i];
    //Dopelniam zerami jesli trzeba
    for(int i = sizeTmp; i < sizeNew; i++)tabTmp[i] = 0;
    //Kasuje stara tablice);
    free(tab);
    // Zamieniam wskazniki i rozmiary
    tab = tabTmp;    
    size = sizeNew;
    
    printf("Wypisuje tablice A:\n");
	cleverPrintTab(tab, size);
	printf("\n");
    
    printf("Usuwam tablice:\n");
    free(tab);

	printf("\n");
*/


rekMergeSort(tab,size);
	printf("Wypisuje posortowana tablice A:\n");
	cleverPrintTab(tab, size);
	printf("\n");
	
printf("Nacisnij dowolny klawisz...");


getche();

} 

// Definicja funkcji

void rekMergeSort(int A[], int s) {
int mid=s/2;
int sid=s-mid;

if(s<=1) { return; }
rekMergeSort(A,mid);
rekMergeSort(A+mid,sid);

int *T;
T=createTab(s);

polacz(A,mid,A+mid,sid,T,s);

for(int i=0; i<s; i++) { A[i]=T[i]; }

free(T);
}

void polacz(int _n[], int a, int _m[], int b, int _t[], int c) {
int i=0,j=0,k=0;
while(i<a && j<b){
if(_n[i]<_m[j]){
_t[k]=_n[i];
i++;
}else{
_t[k]=_m[j];
j++;
}
k++;
}
while(i<a){
_t[k]=_n[i];
i++;
k++;
}
while(j<b){
_t[k]=_m[j];
j++;
k++;
}
}

void zamien(int *a, int *b) {
int temp;
temp=*a; *a=*b; *b=temp;
}

void BubbleSort(int tab[], int n) {
int i=n-1;
while(i) {
    if(tab[i]<tab[i-1]) {
    zamien(&tab[i],&tab[i-1]);
    i=n-1;
    } else { i--; }
}
}

int *createTab(int s) {
int *tab;
tab = (int *)malloc(s * sizeof(int));
if(tab == NULL){
printf("BLAD! Nie mge zaalokowac pamieci!\n");
exit(0);        
}
}

int randomIntValue(int lowerB, int upperB){
    return ((rand() % (upperB-lowerB+1)) + lowerB);
}

void cleverPrintTab(int *t, int s){
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


void fillTab(int *t, int s, int minValue, int maxValue){
    int i;
    for(i = 0; i < s; i++){
        t[i] = randomIntValue(minValue, maxValue);
    }
}


