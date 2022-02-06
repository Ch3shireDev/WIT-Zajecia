#include<stdio.h>
const n=8;
int tab[n]={2,3,5,2,5,6,2,9};
main()
{ int i,min,max,a,A;
  if(tab[0]<tab[1]) {min=tab[0];max=tab[1];}
  else          {min=tab[1];max=tab[0];};
  for(i=2;i<n-1;i+=2)
   {if(tab[i]>tab[i+1]) {A=tab[i];a=tab[i+1];}
    else                {A=tab[i+1];a=tab[i];};
    if(A>max) max=A;
    if(a<min) min=a;
    };
   printf("min=%d Max=%d" ,min,max);
   return 0;
}
