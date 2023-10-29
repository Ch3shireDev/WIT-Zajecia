/*Operator rzutowania.
Program liczy najmniejsza sume kolejnych 1/i,
ktora jest wieksza od rzeczywistej t
i wyswietla liczbe wykonanych iteracji.
Jest to osiagalne poniewaz suma(i=1,n) 1/i -> inf dla n->inf.
*/
#include<stdio.h>
int suma(float t)
{
 int i=1;
float s=0;
while(s<t){
s+=(float)1/i; // s+=1/i; lub s+=(float)(1/i); zle!!!
i++; // s+=1.0/i; lub s+=(float)1/i; ok.
printf("\n%f,",s);
}
return i;
}
main()
{
 float a;
scanf("%f",&a);
printf("\Liczba wykonanych iteracji = %i", suma(a));
}
