#include"stdio.h"
#include"math.h"

struct rekord{
   char plec;
	int wiek;
	float wzrost;
   char imie[30];

};

main(){
   struct rekord dana, danaBis;

   FILE *in, *out;




	printf("Podaj dane osobowe\n");
	printf("Podaj plec  :");
   scanf("%c", &dana.plec);
	printf("Podaj wiek  :");
   scanf("%i", &dana.wiek);
	printf("Podaj wzrost:");
   scanf("%f", &dana.wzrost);
	printf("Podaj imie  :");
   scanf("%s", dana.imie);

	printf("Podane informacje:\n");
	printf("Plec        : %c\n", dana.plec);
	printf("Wiek        : %i\n", dana.wiek);
	printf("Wzrost      : %3.2f\n", dana.wzrost);
	printf("Imie        : %s\n", dana.imie);

   if ((out = fopen("DANE.TXT", "wt")) == NULL){
      printf("Cannot open output file.\n");
      return -1;
   }


	printf("Zapisuje dane do pliku:\n");
	fprintf(out, "%c ", dana.plec);
	fprintf(out, "%i ", dana.wiek);
	fprintf(out, "%3.2f ", dana.wzrost);
	fprintf(out, "%s ", dana.imie);
	printf("Dane zapisane\n");

   fclose(out);

   if ((in = fopen("DANE.TXT", "rt"))== NULL){
      printf("Cannot open input file.\n");
      return -1;
   }
	printf("Odczytuje dane z pliku:\n");
   fscanf(in, "%c", &danaBis.plec);
   fscanf(in, "%i", &danaBis.wiek);
   fscanf(in, "%f", &danaBis.wzrost);
   fscanf(in, "%s", danaBis.imie);
   fclose(in);

	printf("Dane odczytane\n");

	printf("Podane informacje:\n");
	printf("Plec        : %c\n", danaBis.plec);
	printf("Wiek        : %i\n", danaBis.wiek);
	printf("Wzrost      : %3.2f\n", danaBis.wzrost);
	printf("Imie        : %s\n", danaBis.imie);

}


