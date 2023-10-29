#include<stdio.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>

#define REPEAT 2000000
// Prototyp funkcji

double silnia(int val);
double silniaR(int val);

void main(){
    // Inicjacja generatora liczb losowych
	clock_t start,stop;

    printf("Program oblicza sinlie iteracyjnie\n");
    printf("----------------------------------\n");
	printf("\n");
	
	int value, i;
	double sValue;
	
    printf("Podaj liczbe do obliczenia silni:");
	scanf("%i", &value);
	printf("\n");

    printf("Licze silnie %i raz(y)... ", REPEAT);
    start=clock();
    for(i = 0; i < REPEAT; i++){
        sValue = silnia(value);
    }
    stop=clock();
    printf(" zrobione w %f s \n",(float)(stop-start)/CLK_TCK);
    
    printf("Wynik !%i = %.1e\n", value, sValue);
	printf("\n\n");
	
	    printf("Licze silnie R %i raz(y)... ", REPEAT);
    start=clock();
    for(i = 0; i < REPEAT; i++){
        sValue = silniaR(value);
    }
    stop=clock();
    printf(" zrobione w %f s \n",(float)(stop-start)/CLK_TCK);
    
    printf("Wynik !%i = %.1e\n", value, sValue);
	printf("\n");
	
	
	printf("\n");
getche();
}

double silniaR(int val) {
if(val==0 || val==1) { return 1; }

double wynik;
wynik=silniaR(val-1)*val;
return wynik;

}


double silnia(int val){
    double wynik = 1;
    int i;
    for(i = 1; i <= val; i++){
        wynik *= i;
    }
    return wynik;

};

