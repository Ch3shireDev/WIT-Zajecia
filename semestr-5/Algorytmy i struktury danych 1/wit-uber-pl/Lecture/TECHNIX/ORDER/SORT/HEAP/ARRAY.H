

#include <iostream.h>
#include <stdlib.h>
#include <conio.h>


const int MIN_SIZE = 2;



class Array
{

  protected:


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
{
  znak = zn;

  index = 0;

  size = (Size < MIN_SIZE) ? MIN_SIZE : Size;

  dataPtr = new int[size];

}



Array::Array(Array& ar)
{
  copy(ar);
}


Array::~Array()
{
  delete [] dataPtr;
}


void Array::setindex(int k)
{
  index=k;
}
int Array::getsize()
{
  return size;
}



char Array::getznak()
{
  return znak;
}

int Array::recall(int index)
{
   return  dataPtr[index];
}

void Array::mrecall()
{
  cout << endl;

  for(int i = 0; i < getsize(); i++)  cout << recall(i) << " ";

  cout << endl;

  getch();

}



void Array::storeup(int x)
{
   dataPtr[index] = x;

   if(index<getsize()-1) index++;
}


void Array::storedown(int x)
{
   dataPtr[index] = x;

   if(index>0) index--;
}


void Array::mstore()
{ int x;

  cout<< endl;

  for(int i = 0; i < getsize(); i++)
   { x = rand() % 10;
     storeup(x);
   }
}


Array& Array::copy(Array& ar)
{
  delete[] dataPtr;

  znak  = ar.znak;

  size  = ar.size;

  index = ar.index;

  dataPtr = new int[size];

  for( int i = 0; i < size; i++)

      dataPtr[i] = ar.dataPtr[i];

  return *this;
}






