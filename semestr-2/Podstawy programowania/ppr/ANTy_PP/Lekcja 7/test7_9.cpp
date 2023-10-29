#include<stdio.h>
#include<stdlib.h>
#include<time.h>

#define SIZE 20

// Prototyp funkcji (INACZEJ !!!!!!!!!!!!!!!!!!!!!!!!!)
void cleverPrintTab(int *t, int s);
void fillTab(int *t, int s, int minValue, int maxValue);

void main(){
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
    tab = (int *)malloc(size * sizeof(int));
    if(tab == NULL){
        printf("BLAD! Nie mge zaalokowac pamieci!\n");
        exit(-1);        
    }

    printf("Losuje zawartosc tablicy...\n");
    start=clock();
    fillTab(tab, size, 1, 9);	
    stop=clock();
    printf(" zrobione w %f s \n",(float)(stop-start)/CLK_TCK);
	printf("\n");

    printf("Wypisuje tablice A:\n");
	cleverPrintTab(tab, size);
	printf("\n");

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
    system("PAUSE");

} 



// Definicja funkcji
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

