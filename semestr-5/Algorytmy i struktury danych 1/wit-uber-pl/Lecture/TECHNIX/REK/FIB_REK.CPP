#include<stdio.h>
#include<time.h>
#include<dos.h>
#include<conio.h>
long fr(int);
long fi(int);

main()
{
 int ile;
 printf("ile= ");
 scanf("%d",&ile);
 
 clock_t start, end;

 start = clock();
 printf("\nThe start time was: %f\n", start/CLK_TCK);
 printf("\n%ld \n",fi(ile));
 end = clock();
 printf("\nThe the end time was: %f\n", end/CLK_TCK);
 printf("\nThe time was: %f\n", (end - start)/CLK_TCK);
 getch();
 
 start = clock();
 printf("\nThe start time was: %f\n", start/CLK_TCK);
 printf("\n%ld \n",fr(ile));
 end = clock();
 printf("\nThe the end time was: %f\n", end/CLK_TCK);
 printf("\nThe time was: %f\n", (end - start)/CLK_TCK);
 getch();
 
 return 0;
}

long fr(int n)
{ long fib;
  if(n==1 || n==2) fib=1;
  else             fib=fr(n-1)+fr(n-2);
  return fib;
}

long fi(int n)
{ int i;
  long a=0,b=1,c;
  
  if(n>2)
   for(i=2; i<=n; i++)
   {  c=a+b; 
      a=b; 
	  b=c;
   }

  return b;
}

