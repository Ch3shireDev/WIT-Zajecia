#include"stdio.h"
#include"math.h"

struct rozRK{
	int ile;
	float x1, x2;
};

int rownanieKwadratowe1(float a, float b, float c);
int rownanieKwadratowe2(float a, float b, float c, float *x1, float *x2);
struct rozRK rownanieKwadratowe3(float a, float b, float c);


main(){
   float a, b, c, p1, p2;
   int  ile;
   struct rozRK rozwiazanie;


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

	printf("Metoda 2:\n");
	ile = rownanieKwadratowe2(a, b, c, &p1, &p2);
	printf("Rownanie ma %i pierwiastkow\n", ile);
	printf("x1 = %f a x2 = %f\n", p1, p2);

	printf("Metoda 3:\n");
	rozwiazanie = rownanieKwadratowe3(a, b, c);
	printf("Rownanie ma %i pierwiastkow\n", rozwiazanie.ile);
	printf("x1 = %f a x2 = %f\n", rozwiazanie.x1, rozwiazanie.x2);
}

int rownanieKwadratowe1(float a, float b, float c){
	float delta = b*b - 4*a*c;

   if(delta < 0 ) return 0;
   if(delta == 0 ) return 1;
   if(delta > 0 ) return 2;

};

int rownanieKwadratowe2(float a, float b, float c, float *x1, float *x2){
	float delta = b*b - 4*a*c;

   if(delta < 0 ) return 0;
   if(delta == 0 ){
   	*x1 = *x2 = -b/(2*a);
   	return 1;
   }
   if(delta > 0 ){
   	*x1 = (-b - sqrt(delta))/(2*a);
   	*x2 = (-b + sqrt(delta))/(2*a);
   	return 2;
   }

};

struct rozRK rownanieKwadratowe3(float a, float b, float c){
   struct rozRK wynik;

	float delta = b*b - 4*a*c;

   if(delta < 0 ){
      wynik.ile = 0;
      wynik.x1 = wynik.x2 = 0;
   	return wynik;
	}
   if(delta == 0 ){
   	wynik.x1 = wynik.x2 = -b/(2*a);
      wynik.ile = 1;
   	return wynik;
   }
   if(delta > 0 ){
   	wynik.x1 = (-b - sqrt(delta))/(2*a);
   	wynik.x2 = (-b + sqrt(delta))/(2*a);
      wynik.ile = 2;
   	return wynik;
   }

};

