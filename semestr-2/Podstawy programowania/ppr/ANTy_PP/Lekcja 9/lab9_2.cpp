#include"stdio.h"
#include"math.h"

struct rekord{
   char plec;
	int wiek;
	float wzrost;
   char imie[30];

};

main(){
   struct rekord dana;


	printf("Podaj dane osobowe\n");
	printf("Podaj plec  :");
   scanf("%c", &dana.plec);
	printf("Podaj wiek  :");
   scanf("%i", &dana.wiek);
	printf("Podaj wzrost:");
   scanf("%f", &dana.wzrost);
	printf("Podaj imie  :");
   scanf("%s", dana.imie);

	printf("Podane informacje - dana :\n");
	printf("Plec        : %c\n", dana.plec);
	printf("Wiek        : %i\n", dana.wiek);
	printf("Wzrost      : %3.2f\n", dana.wzrost);
	printf("Imie        : %s\n", dana.imie);
}


