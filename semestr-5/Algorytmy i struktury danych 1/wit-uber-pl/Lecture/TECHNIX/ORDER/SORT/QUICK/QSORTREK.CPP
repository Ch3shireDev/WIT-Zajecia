
#include<stdio.h>
#include<stdlib.h>
#include<conio.h>
#define size 10

void   swap(int*, int*) ;
void  input(int [], int, int);
void output(int [], int);
void  qsort(int [], int, int);

main()
{int tab[size];
 input(tab, size, 100);
 output(tab, size-1);
 qsort(tab, 0, size-1);
 output(tab, size-1);
 getch();
}

void qsort(int a[],int l,int p)
{ int v=a[l],i=l,j=p+1;
  do
  { do{i++;}while(a[i]<v);
    do{j--;}while(a[j]>v);
    if(i<j) swap(&a[i],&a[j]);
  }while(i<j);   
  a[l]=a[j];a[j]=v;
  
  if((j-1)>l) qsort(a,l,j-1);
  if((j+1)<p) qsort(a,j+1,p);
}  
   
void swap(int* px, int* py) // x:=:y
{int temp; 
     temp=*px;
     *px=*py;
     *py=temp;  
}   

void input(int a[], int n, int m)
{ for(int i=0; i<n-1; i++) a[i]= rand()%m;
  a[n-1]= 32767;
} 
void output(int a[], int n)
{printf("\n");
 for(int i=0; i<n; i++) printf("%d,", a[i]);
}
