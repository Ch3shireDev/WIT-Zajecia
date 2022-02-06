#include<stdio.h> 
#include<conio.h>
#include<stdlib.h>

const int size_n = 10;
const int size_m = 20; // uwaga: size_m >= size_n 

void       input(int a[], int n, int b[], int m);
void        comp(int a[], int n, int b[], int m, int c[][size_m+1]);
void printmatrix(int a[], int n, int b[], int m, int c[][size_m+1]);
void reconstruct(int a[], int n, int b[], int m, int c[][size_m+1], int temp[]);
void printresult(int a[], int n, int b[], int m, int temp[]);

main()
{ 
  int taba[size_n], tabb[size_m], tabt[size_n];
  int tabc[size_n+1][size_m+1];

        input(taba, size_n, tabb, size_m);
         comp(taba, size_n, tabb, size_m, tabc);
  printmatrix(taba, size_n, tabb, size_m, tabc);
  reconstruct(taba, size_n, tabb, size_m, tabc, tabt);
  printresult(taba, size_n, tabb, size_m, tabt);

  return 0;
  
}


void input(int a[], int n, int b[], int m)
{
  for(int  i = 0; i < n; i++ )  a[i] = rand()%3 + 1;

  for(int  j = 0; j < m; j++ )  b[j] = rand()%4 + 1;
}



void comp(int a[], int n, int b[], int m, int c[][size_m+1])
{ 
  int i, j, max;
 
  for( i = 0; i < n+1; i++ )  c[i][0] = 0;

  for( j = 0; j < m+1; j++ )  c[0][j] = 0;

    
  for( i = 1; i < n+1 ; i++ )

   for( j = 1; j < m+1 ; j++ )

    if(a[i-1]==b[j-1]) 
    
          c[i][j] = c[i-1][j-1]+1;

    else{ 

          if(c[i-1][j] < c[i][j-1]) max = c[i][j-1];

          else                      max = c[i-1][j];

          c[i][j] = max;
        }   
        
}

  

void printmatrix(int a[], int n, int b[], int m, int c[][size_m+1])
{
   int i, j;

   printf("  ");

   for(j = 0; j < m; j++)

       printf("%d,", b[j]);
      
   printf("\n");
        
   for( i = 1; i < n+1 ; i++ )
    {
       printf("%d,", a[i-1]);
       
       for( j = 1; j < m+1 ; j++ )

           printf("%d,", c[i][j]);

       printf("\n");    
    }   
    
}
   


void reconstruct(int a[], int n, int b[], int m, int c[][size_m+1], int temp[])
{
   int i=n, j=m, k=0, pom=c[n][m];

   for(int s = n-1 ; s>=0; s--) temp[s]=0; 
     

   
   while(pom)
   { 
     if(a[i-1]==b[j-1])
      {
        temp[k]=a[i-1];
        i--;
        j--;
        k++;
        pom--;
      }
     else
      {  
           if(c[i-1][j] < c[i][j-1])  j--;

           else                       i--;         
               
      }
   } 

}


void printresult(int a[], int n, int b[], int m, int temp[])
{
   int i, j;
   
   printf("\n");

   for( i = 0; i < n; i++ )  printf("%d,", a[i]);

   printf("\n");
   
   for( j = 0; j < m; j++ )  printf("%d,", b[j]);

   printf("\n");

   for(i = n-1 ; i>=0; i--)

     if(temp[i])  printf("%d,", temp[i]); 

     
   getch();  
           
}           
   
   



