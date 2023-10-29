#include<stdio.h>
#include<stdlib.h>
#include<time.h>

#define SIZE 20

// Prototyp funkcji (INACZEJ !!!!!!!!!!!!!!!!!!!!!!!!!)
int * createTabInt(int s);
void cleverPrintTabInt(int *t, int s);
void fillTabInt(int *t, int s, int minValue, int maxValue);

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
    tab = createTabInt(size);

    printf("Losuje zawartosc tablicy...\n");
    start=clock();
    fillTabInt(tab, size, 1, 9);	
    stop=clock();
    printf(" zrobione w %f s \n",(float)(stop-start)/CLK_TCK);
	printf("\n");

    printf("Wypisuje tablice A:\n");
	cleverPrintTabInt(tab, size);
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

void cleverPrintTabInt(int *t, int s){
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


void fillTabInt(int *t, int s, int minValue, int maxValue){
    int i;
    for(i = 0; i < s; i++){
        t[i] = randomIntValue(minValue, maxValue);
    }
}

int * createTabInt(int s){
    int *t;
    //Tworze tablice;
    t = (int *)malloc(s * sizeof(int));
    if(t == NULL){
        printf("BLAD! Nie moge zaalokowac pamieci!\n");
        exit(-1);        
    }
    return t;
}

