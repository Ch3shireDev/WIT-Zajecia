#include<stdio.h>
#include<stdlib.h>

// Prototyp funkcji
void wizytowka();
int czyTrojkat(float a, float b, float c);

void main(){
    printf("Program sprawdza czy z bokow da sie zbudowac trojkat\n");
    printf("-----------------------------------------------------\n");
	printf("\n");

    // Wywolanie funkcji
    wizytowka();
	printf("\n");
     
    float bok1, bok2, bok3;
    printf("Podaj dlugosc pierwszego boku : ");
    scanf("%f", &bok1);
    printf("Podaj dlugosc drugiego boku   : ");
    scanf("%f", &bok2);
    printf("Podaj dlugosc trzeciego boku  : ");
    scanf("%f", &bok3);

    int decyzja;
    printf("Sprawdzam...");
    decyzja = czyTrojkat(bok1, bok2, bok3);
    printf("zrobione!\n");
    if(decyzja == 1){
        printf("Z bokow o dlugosicach %f %f i %f da sie zbudowac trojkat!\n", bok1, bok2, bok3);
    }
    else{
        printf("Z bokow o dlugosicach %f %f i %f NIE da sie zbudowac trojkat!\n", bok1, bok2, bok3);
    }

	printf("\n");
    system("PAUSE");
}


// Definicja funkcji
void wizytowka(){
   printf("Moja wizytowka\n\n");
   printf("+---------------------------------------------+\n");
   printf("| Autor : _____ ________                      |\n");
   printf("| Grupal: _____ ________                      |\n");
   printf("| E-mail: _____ ________                      |\n");
   printf("+---------------------------------------------+\n");
}

int czyTrojkat(float a, float b, float c){
    float max = a;
    float suma = a + b + c;

    if(max < b){
        max = b;
    }

    if(max < c){
    	max = c;
    }

   if(max < (suma - max)){
       return 1;
   }
   else{
        return 0;
   }
}
