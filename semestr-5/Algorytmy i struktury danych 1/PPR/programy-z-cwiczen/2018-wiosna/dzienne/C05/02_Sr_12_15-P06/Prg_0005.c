#include <stdio.h>
#include <stdlib.h>


int main(){
    int * px;
    int * py;
    /**
    x ?= -5
    |-5| = 5

    */

    px = (int*)malloc(sizeof(int));
    py = (int*)malloc(sizeof(int));

    printf("x ?= ");
    scanf("%d", px);

    *py=*px;

    if(0>*py) *py=-*py;

    printf("|%d| = %d\n", *px, *py);

    return 0;
    }
