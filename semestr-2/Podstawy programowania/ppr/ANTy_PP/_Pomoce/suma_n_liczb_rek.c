/*Program liczy sume kolejnych liczb naturalnych od 0 do n
za pomoca algorytmu rekurencyjnego i iteracyjnego.
*/
#include <stdio.h>
int suma_iter(int n)
{
 int suma=0, i;
for(i=0;i<=n;i++) suma+=i;
return suma;
}
int suma_rek(int n)
{
 if(n==0) return 0;
else return n+suma_rek(n-1);
}
void main()
{
 printf("%i %i", suma_iter(10), suma_rek(10));
}
