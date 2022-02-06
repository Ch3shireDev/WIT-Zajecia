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

