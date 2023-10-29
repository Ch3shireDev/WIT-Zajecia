/* Program oblicza pole i obwod prostokata*/
#include <stdio.h>
void main()
{
 float a,b;
float pole;
printf("Program oblicza pole i obwod prostokata.\n");
printf("\nPodaj dlugosc boku a: ");
fflush(stdin);
scanf("%f", &a);
printf("Podaj dlugosc boku b: ");
fflush(stdin);
scanf("%f", &b);
pole=a*b;
printf("\nPole prostokata wynosi %f,\n", pole);
//mozna podstawic wynik wyrazenia
printf("a obwod %f.\n", 2*a+2*b);
//lub wyrazenie
}
