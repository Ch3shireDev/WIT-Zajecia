#include <iostream.h>

const n=12;

int tab[n]={40,29,2,1,6,18,20,32,34,39,23,41};

void swap(int& a,int &b) // zamieñ miejscami a i b
{
int temp=a;
a=b;
b=temp;
}

void qsort(int *tab,int left, int right)
{
if (left < right)
	{
	int m=left;
	for(int i=left+1;i<=right;i++)
		 if (tab[i]<tab[left])
			swap(tab[++m],tab[i]);
	swap(tab[left],tab[m]);
	qsort(tab,left,m-1);
	qsort(tab,m+1,right);
	}
}

void main()
{
for (int i=0;i<n;i++)
  cout << tab[i] <<"   ";
cout << endl;
qsort(tab,0,n-1);
for (i=0;i<n;i++)
  cout << tab[i] <<"   ";;
cout << endl;
}
