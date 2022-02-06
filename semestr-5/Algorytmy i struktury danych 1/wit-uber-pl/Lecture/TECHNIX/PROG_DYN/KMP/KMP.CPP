#include <iostream.h>
#include <string.h>  // z uwagi na strlen

const M=4;

int shift[M];

//--------------------------------------------
int init_shifts(char *w)
{
 int i,j;
 shift[0]=-1;
 for(i=0,j=-1;i<M-1;i++,j++,shift[i]=j)
	while((j>=0)&&(w[i]!=w[j])) j=shift[j];
}
//--------------------------------------------
int kmp(char *w,char *t)
{
 int i,j,N=strlen(t);
 for(i=0,j=0;i<N && j<M;i++,j++)
	while((j>=0)&&(t[i]!=w[j])) j=shift[j];
 if (j==M) return i-M; else return -1;
}

void main()
{
 char *w="1010";
 init_shifts(w);
 char *t="abcd1010def";
 cout << "Wynik poszukiwañ="<<kmp(w,t)<<endl;
}

