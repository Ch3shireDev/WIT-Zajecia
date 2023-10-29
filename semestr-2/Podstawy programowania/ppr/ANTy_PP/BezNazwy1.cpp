#include<stdio.h>
#include<math.h>
#include<stdlib.h>

main()
{
int a,b,c,delta;
double pierwiastek_delta;
float x,y,z;
//ax*x+bx+c

printf("Podaj a : "); scanf("%d",&a);
printf("\nPodaj b : "); scanf("%d",&b);
printf("\nPodaj c : "); scanf("%d",&c);
delta=((b*b)-(4*a*c));

    if(a==0) {
    printf("\nBrak rozwiazania a=0\n");

    }
    else
    {
        if(delta==0)
        {
        z=(-b)/(2*a);
        printf("\nDelta=%d\n",delta);
        printf("\nRownanie ma jeden pierwiastek rowny %f\n",z);
        }        
        else if(delta>0)
        {
        delta=(b*b)-(4*a*c);
        x=(-b-sqrt(delta))/(2*a);
        y=(-b+sqrt(delta))/(2*a);
        pierwiastek_delta=sqrt(delta);
        printf("\nDelta=%d, pierwiastek z delty=%d\n",delta,pierwiastek_delta);
        printf("\nRownanie kwadratowe ma dwa pierwiastki %f i %f\n",x,y);
        }
        else if(delta<0) {
        printf("Delta jest ujemna i rownanie nie posiada pierwiastkow.\n");
        }

    }

system("pause");

} //END
