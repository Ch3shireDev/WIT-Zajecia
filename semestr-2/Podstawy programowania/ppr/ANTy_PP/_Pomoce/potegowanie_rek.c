/*Program liczy x^n
rekurencyjnie i iteracyjnie.
*/
#include<stdio.h>
#include<stdlib.h>
#include<conio.h>

double potega_iter(double x, int n);
double potega_rek(double x, int n);

main()
{
double x;
int n;
printf("Prosze podac liczbe rzeczwista x=");
fflush(stdin);
scanf("%lf", &x);
printf("Prosze podac liczbe naturalna n=");
fflush(stdin);
scanf("%i", &n);
printf("rekurencyjnie %lf do potegi %i=%lf\n",x,n,potega_rek(x,n));
printf("iteracyjnie %lf do potegi %i=%lf\n",x,n,potega_iter(x,n));
getche();
}

double potega_iter(double x, int n)
{
 int i;
double potega=1.0;
if(n==0&&x==0){
printf("Symbol nieoznaczony.\n");
return -0.0;
}
if(n<0){
n=-n;
if(x!=0) x=1.0/x; else return 0.0;
}
for(i=0;i<n;i++) potega*=x;
return potega;
}
double potega_rek(double x, int n)
{
 double z;
if(n<0) return potega_rek(1.0/x,-n); //  x^n=(1/x)^(-n)
else
if(n==0&&x==0){
printf("Symbol nieoznaczony.\n");
return -0.0;
}else
if(n==0) return 1.0;
else
if(n==0) return x;
else
if (!(n%2)){ //dla przyspieszenia (czesc niekonieczna)
z=potega_rek(x,n/2);
return z*z;//-----------------------------------
}else
return(x*potega_rek(z,n-1));
}
