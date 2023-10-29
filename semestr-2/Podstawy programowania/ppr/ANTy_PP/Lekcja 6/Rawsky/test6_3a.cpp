#include<stdio.h>
#include<stdlib.h>
#include<time.h>

#define REPEAT 2000000
// Prototyp funkcji

double powI(float base, int exp);
double powR(float base, int exp);

void main(){
    // Inicjacja generatora liczb losowych
	clock_t start,stop;

    printf("Program oblicza potege iteracyjnie i rekurencyjnie\n");
    printf("--------------------------------------------------\n");
	printf("\n");
	
	float p;
	int e, i;
	double pValue;
	
    printf("Podaj podstawe potegi:");
	scanf("%f", &p);
    printf("Podaj wykladnik potegi:");
	scanf("%i", &e);
	printf("\n");

    printf("Licze potege iteracyjnie %i raz(y)... ", REPEAT);
    start=clock();
    for(i = 0; i < REPEAT; i++){
        pValue = powI(p,e);
    }
    stop=clock();
    printf(" zrobione w %f s \n",(float)(stop-start)/CLK_TCK);
    
    printf("Wynik %f ^ %i = %.1f\n", p, e, pValue);
	printf("\n");
	

   printf("Licze potege rekurencyjnie %i raz(y)... ", REPEAT);
    start=clock();
    for(i = 0; i < REPEAT; i++){
        pValue = powR(p,e);
    }
    stop=clock();
    printf(" zrobione w %f s \n",(float)(stop-start)/CLK_TCK);
    
    printf("Wynik %f ^ %i = %.1f\n", p, e, pValue);
	printf("\n");
    
	printf("\n");
    system("PAUSE");
}

double powI(float base, int exp){
    double wynik = base;
    int i;
    for(i = 1; i < exp; i++){
        wynik *= base;
    }
    return wynik;


};
double powR(float base, int exp){
    if(exp == 0) return 1;
    if((exp % 2) == 0){
        return (powR(base, exp/2) * powR(base, exp/2));
    }
    return (base * powR(base, exp-1));
};

