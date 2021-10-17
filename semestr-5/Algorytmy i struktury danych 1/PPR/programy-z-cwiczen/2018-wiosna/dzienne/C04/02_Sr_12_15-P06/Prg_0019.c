#include <stdio.h>

int main(){
    int x, i, j;

    printf("x ?= ");
    scanf("%d", &x);

    for(i = 0; i< 2 * x -1;printf(" *"), ++i);
    for(printf("\n"),j = 0; j< x - 2; ++j,printf("\n")){
        for(printf(" *"),i = 0; i < x - 2;printf("  "), ++i);
        for(printf(" *"),i = 0; i< x - 2 - j;printf(" *"), ++i);
        }
    for(i = 0; i< x;printf(" *"), ++i);
    printf("\n");

    return 0;
    }
