#include <stdio.h>
#include <stdlib.h>

int main(){
    int* px;
    int* py;

    px = (int*)malloc(sizeof(int));
    py = (int*)malloc(sizeof(int));

    /** 1, 1
    x ?= -5
    |-5| = 5

    x ?= 7
    |7| = 7
    */
    printf("x ?=");
    scanf("%d", px);

    *py=*px;
    if(0>*py) *py=-*py;

    printf("|%d| = %d\n", *px, *py);


    return 0;
    }
