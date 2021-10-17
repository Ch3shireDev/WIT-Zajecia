#include <stdio.h>
/**
x ?= 4
* * * *
* * *
* *
*

*/
int main(){
    int x, i, j;

    printf("x ?= ");
    scanf("%d", &x);

    for(j = 0; j < x; ++j){
        for(i = 0; i < x - j; ++i){
            printf("* ");
            }
        printf("\n");
        }

    return 0;
    }







