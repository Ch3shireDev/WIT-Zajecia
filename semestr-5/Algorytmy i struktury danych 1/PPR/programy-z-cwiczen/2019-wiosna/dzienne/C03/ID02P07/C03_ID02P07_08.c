#include <stdio.h>

int main(){
    int i, j;
    int x;

    printf("x? = ");
    scanf("%d",&x);

    for(j = 0; j<x;++j){
        for(i = j;i<x;++i){
            printf(" *");
            }
         printf("\n");
        }

    return 0;
    }

/** 2, 3
x? = 5
 * * * * *
 * * * *
 * * *
 * *
 *



*/
