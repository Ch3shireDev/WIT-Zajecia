#include<iostream.h>
#include<conio.h>



class heap
{
  private:
    int *tab;
    int  n; // ilosc elementow
    int  Max;

  public:
    heap();
    heap(int M);
    void insert(int);
    void construct();
    void upheap(int);
    void downheap(int);
    void print();
    int  deletemax();

};



void heap::heap(int M)
{ Max = 4;
  Max = (M > Max)? M : Max;
  tab = new int [Max+1];
  tab[0]=32767;
  n=0;

}



void heap::construct()
{
  for(int i=(Max+1)/2;i>0;i--)  downheap(i);
}


void heap::insert(int v)
{ tab[++n] = v; }



void heap::upheap(int k)
{ int l, v;
  v = tab[k];
  l = k / 2;

  while(tab[l] < v)
   { tab[k] = tab[l];
	 k  =   l;
	 l  = l/2;
   }
  tab[k] =  v;
}


void heap::downheap(int k)
{ int i, j, v;
  tab[0]=32767;
  v = tab[k];
  while(k <= n/2)
   {
     j = 2*k;
     if(j < n)
      if(tab[j] < tab[j+1]) j++;

     if( v >= tab[j]) goto label;

     tab[k] = tab[j];
     k = j;
  }
  label: tab[k] = v;
}


int heap::deletemax()
{ int pom = tab[1];
   tab[1] = tab[n];
  n--;
  downheap(1);
  return pom;
}


void heap::print()
{
  int i=1,j;

  cout <<  endl;

  while(i<=n)
   {
     for(j=0; j<(n-i); j++) cout << " ";
     for(j=i; (j<=n) && (j<2*i);j++) cout << tab[j] << " ";
     i*=2;
     cout << endl;
   }
  cout << endl;

}

