/*Program mnozy dwie liczby calkowite dodatnie za pomoca dodawania.
Algorytmem iteracyjnym i rekurencyjnym.
*/
#include <stdio.h>
int mult_iter(int x, int y)
{
 int suma=0, i;
for(i=0;i<y;i++)
suma+=x;
return suma;
}
int mult_rek(int x, int y)
{
 if(y==1) return x;
else return x+mult_rek(x,y-1);
}
void main()
{
 int l1, l2;
printf("Program mnozy dwie liczby calkowite dodatnie.\n\n");
printf("Podaj a i b: ");
fflush(stdin);
scanf("%i %i", &l1, &l2);
printf("Rekurencyjnie %i*%i=%i\n", l1, l2, mult_rek(l1,l2));
printf("Iteracyjnie %i*%i=%i\n", l1, l2, mult_iter(l1,l2));
}
