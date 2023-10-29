// Operatory logiczne
#include <stdio.h>
void main()
{
 int a,b,c;
fflush(stdin);
scanf("%i %i %i", &a, &b, &c);
printf("Cwiczenia z logiki.\n");
printf("nie %i = %i\n", a, !a);
printf("%i lub %i = %i\n", a, b, a||b);
printf("%i i %i = %i\n", a, b, a&&b);
printf("%i implikuje %i = %i\n", a, b, a<=b);
printf("%i jest rownowazne %i = %i\n", a, b, a==b);
printf("%i xor %i = %i\n", a, b, !(a==b));
printf("(%i i %i) lub (nie %i) = %i\n", a, b, c, a&&b||!c);
printf("jesli %i to %c\n", a, a? 't' : 'n');
// jezeli a!=0 to 't'  inaczej 'n'
// mozna uzywac zamiast if, konstrukcja:
// (wyr-logiczne) ? wyr-jezeli-prawda : wyr-jezeli-falsz;
// odmiennie do if wynik mozna podstawiac pod zmienna
// char zm = (k==0) ? 't' : 'n';
}
