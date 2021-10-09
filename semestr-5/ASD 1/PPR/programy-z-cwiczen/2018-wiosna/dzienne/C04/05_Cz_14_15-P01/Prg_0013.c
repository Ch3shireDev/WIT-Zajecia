#include <stdio.h>
/** 4
x ?= 4
      *
    * *
  * * *
* * * * * * *
        * * *
          * *
            *
*/
int main(){
    int x, i, j;

    printf("x ?= ");
    scanf("%d", &x);

    for(j = 0; j< x-1; ++j){
        for(i = 0; i<x-1-j; ++i)
            printf("  ");
        for(; i<x; ++i)
            printf("* ");
        printf("\n");
        }

    for(i = 0; i < 2*x-1; ++i)
        printf("* ");
    printf("\n");

    for(j = 0; j< x-1; ++j){
        for(i = 0; i<x + j; ++i)
            printf("  ");
        for(i=0; i<x-1-j;++i)
            printf("* ");
        printf("\n");
        }
    return 0;
    }







