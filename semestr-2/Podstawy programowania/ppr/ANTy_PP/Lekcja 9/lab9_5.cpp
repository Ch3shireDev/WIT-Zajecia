#include"stdio.h"
#include"stdlib.h"
#include"math.h"

struct rekord{
   char plec;
	int wiek;
	float wzrost;
   char imie[30];

};

main(){
   struct rekord *baza;
   int i, size;

   FILE *in, *out;

   printf("Podaj rozmiar bazy:");
   scanf("%i", &size);

   baza = (struct rekord *) malloc(sizeof(struct rekord) *size);
   if(baza == NULL){
      printf("Cannot create table.\n");
      return -1;
   }

	printf("\n");
	for(i = 0; i < size; i++){
      printf("Podaj dane osobowe %i osoby\n",i);
      fflush(stdin);
      printf("Podaj plec  :");
      scanf("%c", &baza[i].plec);
      printf("Podaj wiek  :");
      scanf("%i", &baza[i].wiek);
      printf("Podaj wzrost:");
      scanf("%f", &baza[i].wzrost);
      printf("Podaj imie  :");
      scanf("%s", baza[i].imie);
   }

	printf("\n");
	printf("Podane informacje:\n");
   printf("--------------------------------------\n");
	for(i = 0; i < size; i++){
      printf("Dane osobowe %i osoby\n",i);
		printf("Plec        : %c\n", baza[i].plec);
		printf("Wiek        : %i\n", baza[i].wiek);
		printf("Wzrost      : %3.2f\n", baza[i].wzrost);
		printf("Imie        : %s\n", baza[i].imie);
   printf("--------------------------------------\n");
   }
	printf("\n");

   if ((out = fopen("DANE.TXT", "wt")) == NULL){
      printf("Cannot open output file.\n");
      return -1;
   }


	printf("Zapisuje do pliku wielkosc bazy\n");
   fprintf(out, "%i ", size);
	printf("\n");

	printf("Zapisuje dane do pliku:\n");
	for(i = 0; i < size; i++){
      fprintf(out, "%c ", baza[i].plec);
      fprintf(out, "%i ", baza[i].wiek);
      fprintf(out, "%3.2f ", baza[i].wzrost);
      fprintf(out, "%s ", baza[i].imie);
	}
	printf("Dane zapisane\n");

   fclose(out);

   free(baza);

	printf("\n");
   // Tworze od nowa
   printf("---------------------.\n");
   printf("Tworze baze od nowa...\n");
   printf("---------------------.\n");

   if ((in = fopen("DANE.TXT", "rt"))== NULL){
      printf("Cannot open input file.\n");
      return -1;
   }

	printf("Odczytuje z pliku wielkosc bazy\n");
   fscanf(in, "%i ", &size);
	printf("\n");

   baza = (struct rekord *) malloc(sizeof(struct rekord) *size);
   if(baza == NULL){
      printf("Cannot create table.\n");
      return -1;
   }

	printf("Odczytuje dane z pliku:\n");
	for(i = 0; i < size; i++){
      fscanf(in, "%c", &baza[i].plec);
      fscanf(in, "%i", &baza[i].wiek);
      fscanf(in, "%f", &baza[i].wzrost);
      fscanf(in, "%s", baza[i].imie);
      fgetc(in);
   }
	printf("Dane odczytane\n");
   printf("--------------------------------------\n");
	for(i = 0; i < size; i++){
      printf("Podaj dane osobowe %i osoby\n",i);
		printf("Plec        : %c\n", baza[i].plec);
		printf("Wiek        : %i\n", baza[i].wiek);
		printf("Wzrost      : %3.2f\n", baza[i].wzrost);
		printf("Imie        : %s\n", baza[i].imie);
   printf("--------------------------------------\n");
   }

}


