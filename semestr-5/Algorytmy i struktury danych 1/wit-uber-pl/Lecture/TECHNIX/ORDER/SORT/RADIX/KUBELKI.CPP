#include<stdio.h>
#include<string.h>
#include<conio.h>

const int w=9;    /* liczba wierszy   */
const int k=4;    /* liczba kolumn    */
const int s=24;   /* rozmiar alfabetu */ 

void read(char [][k], char *[]);
void countsort(char *[],int);
void radixsort(char *[]);
void write(char *[]);

int main(void)
{   char *wsk[w];
    char dane[w][k] =
	{"aba","aaa","bab",
	 "cac","bac","bca",
	 "bab","abb","baa"}; 
    read(dane,wsk);
    radixsort(wsk) ;
    getch();
    return 0;
}

void read(char dane[w][k], char *wsklan[w])
{  for(int i=0;i<w;i++) wsklan[i]=dane[i]; }

void write(char *wsklan[w])
{printf("\n\n");
 for(int i=0;i<w;i++) puts(wsklan[i]);
 getch();
}

void countsort(char *wsklan[w], int p)
{   int i;
    char x;
    int count[s]={0};
    char *temp[w];
	/* zliczanie */
	for(i=0;i<w;i++) count[*(wsklan[i]+p) - 97]++;
	for(i=1;i<s;i++) count[i] += count[i-1];
	for(i=0;i<s;i++) if(count[i]) count[i]--;
	/* porzadkowanie */
	for(i=w-1;i>=0;i--)
	{ x=*(wsklan[i]+p);
        temp[count[x-97]]=wsklan[i];
	  count[x-97]--;
	}
	/* przepisywanie */
      for(i=0;i<w;i++)  wsklan[i]=temp[i];
}

void radixsort(char *wsklan[w])
{   write(wsklan);
    for(int i=k-2; i>=0;i--)
	{ countsort(wsklan,i);
	  write(wsklan);
    }
}
