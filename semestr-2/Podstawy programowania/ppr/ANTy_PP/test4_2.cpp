#include<stdio.h>
#include<stdlib.h>

// Prototyp funkcji
void wizytowka();
void wypiszKwadrat(int a);

void main(){
    printf("Program testujacy funkcje  \n");
    printf("--------------------------\n");
	printf("\n");

    printf("Wypisze na ekran wizytowke\n");
    // Wywolanie funkcji
    wizytowka();
    
	printf("\n");
    printf("Wypisze na ekran kwadrat\n");
    int bok;
    printf("Podaj bok kwadratu : ");
    scanf("%i", &bok);    
    wypiszKwadrat(bok);
    

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

void wypiszKwadrat(int a){
    int i, j;
    for(i = 1; i <= a; i++){
        for(j = 1; j <= a; j++){
            printf("*");
        }    
        printf("\n");
    }
};

