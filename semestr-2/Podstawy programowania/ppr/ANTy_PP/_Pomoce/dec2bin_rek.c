/*Program wypisuje liczbe dziesietna w postaci binarnej
za pomoca algorytmu rekurencyjnego i iteracyjnego.
*/
#include <stdio.h>
void bin_iter(int n)
{
 int i=1;
while(n>=i) i*=2;
i/=2; // najwieksze 2^k zawarte w n
while(i){
printf("%i", n/i);
n%=i;
i/=2;
}
}
void bin_rek(int n)
{
 if(n){
bin_rek(n/2);
if(n%2) printf("1");
else printf("0");
}
}
void main()
{
 int a;
fflush(stdin);
scanf("%i", &a);
bin_rek(a);
printf("\n");
bin_iter(a);
}
