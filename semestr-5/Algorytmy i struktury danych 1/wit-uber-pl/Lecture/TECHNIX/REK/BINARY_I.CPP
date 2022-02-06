#include <iostream.h>
const int n=12;
int tab[n]={1,2,6,18,20,23,29,32,34,39,40,41};

int szukaj(int tab[],int x)
{
enum {TAK,NIE}Znalazlem=NIE;
int left=0,right=n-1,mid;
while(left<=right && Znalazlem!=TAK)
{
mid=(left+right)/2;
if(tab[mid]==x) Znalazlem=TAK;else
	if(tab[mid]<x) 	left=mid+1;else
			right=mid-1;
}
if(Znalazlem==TAK) return mid; else return -1;
}

void main()
{
cout << szukaj(tab,7)<<endl;
}

ÿ