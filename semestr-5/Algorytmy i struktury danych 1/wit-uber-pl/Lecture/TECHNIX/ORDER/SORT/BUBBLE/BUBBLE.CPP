#include <iostream.h>

const n=7;

int tab[n]={4,6,18,20,39,40,2};

void bubble(int *tab)
{
for (int i=1;i<n;i++)
		for (int j=n-1;j>=i;j--)
		if (tab[j]<tab[j-1])
		{//swap
		int tmp=tab[j-1];
		tab[j-1]=tab[j];
		tab[j]=tmp;
		}
}

void main()
{
for (int i=0;i<n;i++)
cout << tab[i] <<"   ";;
cout << endl;
bubble(tab);
for (i=0;i<n;i++)
cout << tab[i] <<"   ";
cout << endl;
}
