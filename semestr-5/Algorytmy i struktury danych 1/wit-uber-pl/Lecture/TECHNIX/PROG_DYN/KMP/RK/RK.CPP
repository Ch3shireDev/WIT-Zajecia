#include<iostream.h>
#include<string.h>
#include<ctype.h>

int indeks(char c)
{
switch(c)
 {
 case ' ':return 0;  // spacja=0
 case 'ê':return 53;
 case 'Ê':return 54; // polskie litery
 case '³':return 55;
 case '£':return 56;// itd. dla pozosta³ych polskich liter
 default: if(islower(c)) return c-'a'+1; else return c-'A'+27;
 }
}

const long p=33554393; // du¿a liczba pierwsza
const int b=64; // du¿e + ma³e znaki + "coœ jeszcze"
//-------------------------------------------------------
int rk(char w[],char t[])
{
unsigned long i,bM_1=1,Hw=0,Ht=0,M=strlen(w),N=strlen(t);
for(i=0;i<M;i++)
  {
  Hw=(Hw*b+indeks(w[i]))%p;  	//inicjacja funkcji H dla wzorca
  Ht=(Ht*b+indeks(t[i]))%p;  	//inicjacja funkcji H dla tekstu
  }
for(i=1;i<M;i++) bM_1=(b*bM_1)%p;
for(i=0;Hw!=Ht;i++)	     	// przesuwanie sie w tekscie
  {
  Ht=(Ht+b*p-indeks(t[i])*bM_1)%p;
  Ht=(Ht*b+indeks(t[i+M]))%p;
  if (i>N-M) return -1;		// porazka poszukiwan
  }
return i;
}
//-------------------------------------------------------
void main()
 {
 char *t="Z pamiêtnika m³odej lekarki";
 cout << "Wynik poszukiwañ="<<rk("lek",t)<<endl;
 }
