#include <stdio.h>
/** 6 + 1, 7 + 2,  8 + 3
x ?= 6
* * * * * * * * * * *
* * * * * *       *
* * * * * *     *
* * * * * *   *
* * * * * * *
* * * * * *

*/
int main(){
    int x, i, j;

    printf("x ?= ");
    scanf("%d", &x);

    for(j = 0; j < 2*x-1;printf("* "), ++j);
    printf("\n");

    for(j = 0; j < x - 2; ++j){
        printf("* ");
        for(i = 0; i < x -2; ++i)
            printf("* ");
        printf("* ");
        for(i=0; i < x -3-j; ++i)
            printf("  ");
        printf("*\n");
        }

    for(j = 0; j < x;printf("* "), ++j);
    printf("\n");

    return 0;
    }







