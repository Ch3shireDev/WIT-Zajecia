#include<iostream.h>
#include<string.h>
#include<ctype.h>

const K=26*2+2*2+1;// znaki ASCII+polskie litery+spacja

int shift[K];
//-------------------------------------------------------
int indeks(char c)
{
switch(c)
 {
 case ' ':return 0;         // spacja=0
 case 'ê':return 53;
 case 'Ê':return 54;     // polskie litery
 case '³':return 55;
 case '£':return 56;     // itd. dla pozosta³ych polskich liter
 default:
		if(islower(c))
			return c-'a'+1;
		else return c-'A'+27;
 }
}
//-------------------------------------------------------
int init_shifts(char *w)
{
int M=strlen(w);
for(int i=0;i<K;i++) shift[i]=M;
for(i=0;i<M;i++)
  shift[indeks(w[i])]=M-i-1;
}
//-------------------------------------------------------
int bm(char *w,char *t)
{
init_shifts(w);
int i, j,N=strlen(t),M=strlen(w);
for(i=M-1,j=M-1;j>0;i--,j--)
  while(t[i]!=w[j])
	{
	int x=shift[indeks(t[i])];
	if(M-j>x) i+=M-j;else
		  i+=x;
	if (i>=N) return -1;
	j=M-1;
	}
return i;
}
//-------------------------------------------------------
void main()
 {
 char *t="Z pamiêtnika m³odej lekarki";
 cout << "Wynik poszukiwañ="<<bm("lek",t)<<endl;
 }


