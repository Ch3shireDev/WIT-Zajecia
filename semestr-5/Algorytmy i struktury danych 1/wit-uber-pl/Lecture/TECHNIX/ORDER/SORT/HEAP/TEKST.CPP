///Array.h//////////////////////////////////////////////////////////////////////
#include <iostream.h>
#include <stdlib.h>
#include <conio.h>
const int MIN_SIZE = 2;

class Array
{ protected:
    char znak;
    int  size;
    int  *dataPtr;
    int  index;
  public:
    Array(char znak, int Size = MIN_SIZE);
    Array(Array& ar);
    ~Array();
    int    getsize();
    char   getznak();
    void   storeup(int);
    void   storedown(int);
    void   mstore();
    int    recall(int index);
    void   mrecall();
    void   setindex(int);
    Array& copy(Array& ar);
};

Array::Array(char zn, int Size)
{ znak = zn;
  index = 0;
  size = (Size < MIN_SIZE) ? MIN_SIZE : Size;
  dataPtr = new int[size];
}
Array::Array(Array& ar)
{ copy(ar); }
Array::~Array()
{ delete [] dataPtr; }
void Array::setindex(int k)
{ index=k; }
int Array::getsize()
{ return size; }
char Array::getznak()
{ return znak; }
int Array::recall(int index)
{ return  dataPtr[index]; }
void Array::mrecall()
{ cout << endl;
  for(int i = 0; i < getsize(); i++)  cout << recall(i) << " ";
  cout << endl;
  getch();
}
void Array::storeup(int x)
{  dataPtr[index] = x;
   if(index<getsize()-1) index++;
}
void Array::storedown(int x)
{  dataPtr[index] = x;
   if(index>0) index--;
}
void Array::mstore()
{ int x;
  cout<< endl;
  for(int i = 0; i < getsize(); i++)
   { x = rand() % 10;
     storeup(x); }
}

Array& Array::copy(Array& ar)
{ delete[] dataPtr;
  znak  = ar.znak;
  size  = ar.size;
  index = ar.index;
  dataPtr = new int[size];
  for( int i = 0; i < size; i++)
  dataPtr[i] = ar.dataPtr[i];
  return *this;
}
///Heap.h///////////////////////////////////////////////////////////////////////
#include<iostream.h>
#include<conio.h>

class heap
{ private:
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
{ for(int i=(Max+1)/2;i>0;i--)  downheap(i); }
void heap::insert(int v)
{ tab[++n] = v; }
void heap::upheap(int k)
{ int l, v;
  v = tab[k];
  l = k / 2;
  while(tab[l] < v)
   { tab[k] = tab[l]; k = l;  l  = l/2; }
  tab[k] =  v;
}
void heap::downheap(int k)
{ int i, j, v;
  tab[0]=32767;
  v = tab[k];
  while(k <= n/2)
   { j = 2*k;
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
{ int i=1,j;
  cout <<  endl;
  while(i<=n)
   { for(j=0; j<(n-i); j++) cout << " ";
     for(j=i; (j<=n) && (j<2*i);j++) cout << tab[j] << " ";
     i*=2;
     cout << endl;
   }
  cout << endl;
}
///Heapsort.cpp/////////////////////////////////////////////////////////////////
#include <iostream.h>
#include "heap.h"
#include "array.h"
const int n=15;
main()
{ int x;
  Array a('a',n);
  clrscr();
  a.mstore();
  a.mrecall();
  heap sterta(n);
  for(int i=0;i<n;i++)
   { x=a.recall(i);
     sterta.insert(x);
   }
  sterta.print();
  sterta.construct();
  sterta.print();
  a.setindex(n-1);
  for(i=0;i<n;i++)
   { x = sterta.deletemax();
     a.storedown(x);
     sterta.print();
     getch();
   }
  a.mrecall();
  getch();
  return 0;
}



