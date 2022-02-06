#include<stdio>
#include<conio.h>

const int n=9;

void swap(int *,int *);
void next(int [],int );
void pisz(int [],int );

main()
{
 int a[n]={1,4,6,2,9,5,8,7,3};
 pisz(a,n);
 next(a,n);
 pisz(a,n);
 getch();
 return 0;
}

void next(int t[], int n)
{ int i=n-2,j=n-1;
  while(t[i]>t[i+1])i--;    /* tu kontrola zakresow nie jest konieczna */
  while(t[j]<t[i])  j--;    /* tu kontrola zakresow nie jest konieczna */
  swap(&t[i],&t[j]);
  i++; j=n-1;
  while(i<j) swap(&t[i++],&t[j--]);
}  
  
void swap(int *x,int *y)
{int temp=*x;
       *x=*y;
       *y=temp;
}       
     
void pisz(int t[],int n)
{ for(int i=0;i<n;i++) printf("%d ",t[i]);
  printf("\n");
}

/*
1 4 6 2 9 5 8 7 3
1 4 6 2 9 7 3 5 8
*/

