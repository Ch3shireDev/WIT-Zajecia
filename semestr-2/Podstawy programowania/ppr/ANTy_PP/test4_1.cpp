#include<stdio.h>
#include<stdlib.h>

// Prototyp funkcji
void wizytowka();

void main(){
    printf("Program testujacy funkcje  \n");
    printf("--------------------------\n");
	printf("\n");

    // Wywolanie funkcji
    wizytowka();
    
    int ile, i;
    printf("Podaj ile razy mam wypisac wizytowke : ");
    scanf("%i", &ile);
    for(i = 1; i <= ile; i++){
        wizytowka();
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
