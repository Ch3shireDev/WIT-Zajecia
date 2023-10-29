#include"stdio.h"
#include"math.h"
int rownanieKwadratowe1(float a, float b, float c);


main(){
   float a, b, c;
   int  ile;



	printf("Rozwiazanie rownania kwadratowego Ax^2 + Bx + C\n");
	printf("Podaj A:");
   scanf("%f", &a);
	printf("Podaj B:");
   scanf("%f", &b);
	printf("Podaj C:");
   scanf("%f", &c);

	printf("Metoda 1:\n");
	ile = rownanieKwadratowe1(a, b, c);
	printf("Rownanie ma %i pierwiastkow\n", ile);
	printf("Ja nie wiem jakie\n");

}

int rownanieKwadratowe1(float a, float b, float c){
	float delta = b*b - 4*a*c;

   if(delta < 0 ) return 0;
   if(delta == 0 ) return 1;
   if(delta > 0 ) return 2;

};


