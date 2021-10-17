#include <stdio.h>

int main(){
    int x, i, j;

    printf("x ?= ");
    scanf("%d", &x);

    for(i = 0; i< 2 * x -1; ++i)
        printf(" *");
    printf("\n");


    for(j = 0; j< x - 2; ++j){
        printf(" *");
        for(i = 0; i < x - 2; ++i)
            printf("  ");
        printf(" *");

        for(i = 0; i< x - 2 - j; ++i)
            printf(" *");
        printf("\n");
        }

    for(i = 0; i< x; ++i)
        printf(" *");
    printf("\n");

    return 0;
    }
