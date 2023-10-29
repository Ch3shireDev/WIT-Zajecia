#include<stdio.h>
#include<stdlib.h>
#include<time.h>
#include<string.h>

#define SIZE 20

// Prototyp funkcji (INACZEJ !!!!!!!!!!!!!!!!!!!!!!!!!)
int scanForWord(char s[], char word[]);

void main(){
    // Inicjacja generatora liczb losowych
    srand((unsigned) time(NULL));
	clock_t start,stop;


    printf("Tworzenie tablicy napisow\n");
    printf("--------------------------\n");
	printf("\n");

    char **tab;
    char buforLinii[1024];
    int sizeX, sizeY;
    printf("Podaj liczbe napisow : ");
    scanf("%i", &sizeX);
    
    printf("Tworze tablice:\n");
    //Tworze listwe pionowa
    tab = (char **)malloc(sizeX * sizeof(char*));
    if(tab == NULL){
        printf("BLAD! Nie moge zaalokowac pamieci!\n");
        exit(-1);        
    }
    
    //Tworze listwy poziome
    int i;
    for(i = 0; i < sizeX; i++){
        // Odczytaj kolejny napis
        printf("Podaj napis nr. %i : ", i);
        fflush(stdin);
        gets(buforLinii);
        sizeY = strlen(buforLinii)+1;
        //Stworz dla niego miejsce
        tab[i] = (char *)malloc(sizeY * sizeof(char));
        if(tab[i] == NULL){
            printf("BLAD! Nie moge zaalokowac pamieci!\n");
            exit(-1);        
        }    
        //Skopiuj
        strcpy(tab[i], buforLinii);
    }


    printf("Wypisuje tablice napisow:\n");
    for(i = 0; i < sizeX; i++){
        // Odczytaj kolejny napis
        puts(tab[i]);
    }
	printf("\n");
    
    printf("Szukanie fragmentu tekstu w napisach.\n");
    printf("Podaj fragment do znalezienia : ");
    gets(buforLinii);
    // Przegladam napisy (tekstu w poszukiwaniu innego tekstu)
    for(i = 0; i < sizeX; i++){
        // Odczytaj kolejny napis

//       if(scanForWord(tab[i], buforLinii) == 1){
       if(strstr(tab[i], buforLinii) != NULL ){
          printf("Napis %i -> Fraza znaleziona\n", i);
       }
       else{
          printf("Napis %i -> Fraza nie wystepuje\n", i);
       }
    }
	printf("\n");

    printf("Usuwam tablice:\n");
    for(i = 0; i < sizeX; i++) free(tab[i]);
    free(tab);
	printf("\n");
    system("PAUSE");
} 

// baza ksiazek,
// przechowywac jako lista statyczna
// przeszukanie katalogu
// sortuj : rok wydania
// katalog : ksiazki, plyty, samochody


// zrobic kalkulator z nawiasami
// sinusy kosinusy potegi itp.
// rekurencja lub drzewo

// comi wojadzer
// wyliczyc dlugosc
//
//

int scanForWord(char s[], char word[]){
   int dl1 = strlen(s);
   int dl2 = strlen(word);
   int i, j;
   for(i = 0; i < dl1; i++){
      if(s[i] == word[0]){
         for(j = 1; j < dl2; j++){
            if(s[i+j] != word[j]) break;
         }
         if(j == dl2) return 1;
      }
   }
   return 0;
}

