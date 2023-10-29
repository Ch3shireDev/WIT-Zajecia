/*Program liczy ilosc bitow ustawionych podanej liczby dziesietnej,
czyli ilosc jedynek danej liczby w kodzie binarnym
za pomoca algorytmu rekurencyjnego i iteracyjnego.
*/
#include <stdio.h>
int il_iter(int n)
{
 int b=0;
while(n){
if (n%2) b++;//jezeli reszta z dzielenia jest rowna 1
n/=2;
}
return b;
}
int il_rek(int n)
{
 if(n==0) return 0;
else if(n%2) return il_rek(n/2)+1;
else return il_rek(n/2);
}
void main()
{
 int x=12;
printf("%i %i", il_iter(x), il_rek(x));
}
