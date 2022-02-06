#include<conio.h>
#include<stdio.h>
const int n=10;
main()
{ int t[n]={1,1,1,1,1,1,1,2,2,2};
  int l=0, r=n-1, m, z=0;
  
  while(l<=r && !z)
   { printf("%d,%d\n", l,r);
     m=(l+r)/2;
     if((t[0]+1==t[m]) && (t[m]>t[m-1])) z=1; 
     else if(t[0]<t[m]) r=m-1;
          else          l=m+1;
   }
   if(z) printf("%d",m);
   else  printf("nie ma");
   getch();
}           
   














   