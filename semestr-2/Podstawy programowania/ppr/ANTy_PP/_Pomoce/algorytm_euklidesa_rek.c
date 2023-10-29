/*Program liczy NWD(a,b) algorytmem Euklidesa
rekurencyjnie i iteracyjnie.
*/
#include <stdio.h>
int NWD_iter(int a, int b)
{
 int temp;
while(b){
temp=b;
b=a%b;
a=temp;
}
return a;
}
int NWD_rek(int a, int b)
{
 if(b==0) return a;
else return NWD_rek(b,a%b);
}
void main()
{
 int a,b;
fflush(stdin);
scanf("%i", &a);
fflush(stdin);
scanf("%i", &b);
printf("nwd(%d,%d)=%d\n",a,b,NWD_rek(a,b));
printf("nwd(%d,%d)=%d\n",a,b,NWD_iter(a,b));
}
