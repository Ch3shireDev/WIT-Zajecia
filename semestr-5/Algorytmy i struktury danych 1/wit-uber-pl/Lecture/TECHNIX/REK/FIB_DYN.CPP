#include <iostream.h>

unsigned long int  fib(int x)
{
if (x<2) return 1; else
   return fib(x-1)+fib(x-2);
}

void fib_dyn(int x, int f[])
{
f[0]=1;
f[1]=1;
for(int i=2;i<x;i++)
  f[i]=f[i-1]+f[i-2];
}

void main()
{
int f[100];
fib_dyn(16,f); // oblicza 15 kolejnych elementow ciagu Fibonacciego
for(int i=0;i<=15;i++)
  cout << "fib("<<i<<")="<<fib(i) << "  " << f[i] << endl;
}
ÿ