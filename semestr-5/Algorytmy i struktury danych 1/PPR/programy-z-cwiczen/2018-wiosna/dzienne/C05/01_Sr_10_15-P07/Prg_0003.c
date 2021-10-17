#include <stdio.h>
#include <stdlib.h>

int main(){
    int* px, *py;
    px =(int*)malloc(sizeof(int));
    py =(int*)malloc(sizeof(int));

    printf("x ?= ");
    scanf("%d", px);

    *py = *px;
    if(*py < 0) *py = -*py;

    printf("|%d| = %d\n", *px, *py);

    return 0;
    }
