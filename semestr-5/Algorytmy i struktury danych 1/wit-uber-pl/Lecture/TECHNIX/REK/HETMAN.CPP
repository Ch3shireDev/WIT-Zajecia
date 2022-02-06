#include<stdio.h>
#include<conio.h>

const int w=8;
const int p=15;

int a[w]; /* wiersze   - */
int b[p]; /* przekatne / */
int c[p]; /* przekatne \ */
int x[w]; /* kolumny   | */ 

void start(void);
void drukuj(void);
void probuj(int);

main()
{ start();
  probuj(0);
}

void start(void)
{
   int i;
   for(i=0;i<w;i++) a[i]=1;
   for(i=0;i<p;i++) b[i]=1;
   for(i=0;i<p;i++) c[i]=1;
}

void drukuj(void)
{ for(int i=0;i<w;i++) printf("%d ", x[i]);
  getch();
  printf("\n");
}

void probuj(int i)
{ int j;
  for(j=0;j<w;j++)
   if(a[j] && b[i+j] && c[i-j+w-1])
   {  x[i]=j;
      a[j]=0; b[i+j]=0; c[i-j+w-1]=0;
	  if(i<w-1) probuj(i+1);
      else      drukuj();
      a[j]=1; b[i+j]=1; c[i-j+w-1]=1;
   }
}
