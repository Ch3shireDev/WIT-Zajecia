#include <stdio.h>
/**
x ?= 4
      *
    * *
  * * *
* * * *

*/
int main(){
    int x, i, j;

    printf("x ?= ");
    scanf("%d", &x);

    for(j = 0; j < x;printf("\n"), ++j){
        for(i = 0; i< x - 1 -j;printf("  "), ++i);
        for(; i < x;printf("* "), ++i);
        }

    return 0;
    }







