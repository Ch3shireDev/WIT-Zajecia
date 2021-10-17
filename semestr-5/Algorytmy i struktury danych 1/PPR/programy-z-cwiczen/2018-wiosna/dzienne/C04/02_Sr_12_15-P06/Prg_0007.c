#include <stdio.h>

int main(){
    int x, y, i, j;

    printf("x ?= ");
    scanf("%d", &x);

    printf("y ?= ");
    scanf("%d", &y);


    for(j = 0; j < x; ++j){
        for(i = 0;i < y; ++i){
            printf(" *");
            }
        printf("\n");
        }

    return 0;
    }
