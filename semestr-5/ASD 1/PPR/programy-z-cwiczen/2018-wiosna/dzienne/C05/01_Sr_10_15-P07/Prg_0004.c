#include <stdio.h>
#include <stdlib.h>

int main(){
    int* px, *py;
    px =(int*)malloc(sizeof(int));
    py =(int*)malloc(sizeof(int));

    printf("x ?= ");
    scanf("%d", px);

    if(*px < 0) *py = -*px;
    else  *py = *px;

    printf("|%d| = %d\n", *px, *py);

    return 0;
    }
