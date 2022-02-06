#include<stdio.h>
const n=8;
int tab[n]={2,3,5,2,5,6,2,9};
main()
{int i, max=tab[0],min=tab[0];
 for(i=1;i<n;i++) if(tab[i]>max) max=tab[i];
 for(i=1;i<n;i++) if(tab[i]<min) min=tab[i];
 printf("\n max=%d, min=%d", max,min);
 return 0;
}  