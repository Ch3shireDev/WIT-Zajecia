#include <stdio.h>

int main(){
    int x, i;

    printf("x ?= ");
    scanf("%d", &x);
/**
   x ?=4
   i = 0
   i = 1
   i = 2
   i = 3
*/

    i = 0;
    while( i < x){
        printf("i = %d\n",i++);
        }

/**
   x ?=4
   i = 1
   i = 2
   i = 3
   i = 4
*/
    i = 0;
    while( i < x){
        printf("i = %d\n",++i);
        }


    return 0;
    }







