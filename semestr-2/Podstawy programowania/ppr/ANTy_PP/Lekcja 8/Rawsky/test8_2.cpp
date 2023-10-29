#include<stdio.h>
#include<stdlib.h>
#include<time.h>

#define SIZE 20

// Prototyp funkcji (INACZEJ !!!!!!!!!!!!!!!!!!!!!!!!!)
int * createTabInt(int s);
void cleverPrintTabInt(int *t, int s);
void fillTabInt(int *t, int s, int minValue, int maxValue);
void bubbleSortInt(int *tab,int s);
void recursiveMergeSortInt(int t[], int n);
void mergeTabInt(int t1[],int s1, int t2[],int s2, int t3[],int s3);

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
    

    printf("Sortuje zawartosc tablicy...\n");
    start=clock();
//    bubbleSortInt(tab, size);	
    recursiveMergeSortInt(tab, size);    
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

void bubbleSortInt(int *tab,int s){
   // Sortowanie tablicy metoda babelkowa
   int i, j;
   int tmpValue;
   // Powtorz 'size - 1' razy przesuwanie babelka
   for(i = 0; i < s - 1; i++){
     // w danym cyklu porownaj 'size - 1' par babelkow
     for(j = 0; j < s - 1; j++){
        if(tab[j+1] < tab[j]){
           tmpValue = tab[j];
           tab[j] = tab[j+1];
           tab[j+1] = tmpValue;
        }
     }
   }
   // Zrobione
}

void recursiveMergeSortInt(int A[], int n) {
	int mid, i;
	if (n<=1) {
		return;
	}
	mid = n/2;
	recursiveMergeSortInt(A, mid);
	recursiveMergeSortInt(A+mid, n-mid);

	int *T;
   T = (int *) malloc(sizeof(int) * n);
   if(T == NULL){
   	printf("Brak pamieci!!!");
      exit(-1);
   }

    mergeTabInt(A, mid, A+mid, n-mid, T, n);
   for(i = 0; i < n; i++){
   	A[i] = T[i];
   }
   free (T);
}

void mergeTabInt(int t1[],int s1, int t2[],int s2, int t3[],int s3){
	int i1, i2, i3;
   i1 = i2 = i3 = 0;
	while(i1 < s1 && i2 < s2){
   	if(t1[i1] < t2[i2]) t3[i3++] = t1[i1++];
   	else t3[i3++] = t2[i2++];
   }
	while(i1 < s1){
   	t3[i3++] = t1[i1++];
   }
	while(i2 < s2){
   	t3[i3++] = t2[i2++];
   }

};

