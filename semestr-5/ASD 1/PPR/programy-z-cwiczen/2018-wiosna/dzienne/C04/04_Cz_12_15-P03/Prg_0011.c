#include <stdio.h>
/** 4, 5, 6
x ?= 6
* * * * * *
* * * * * *
*   * * * *
*     * * *
*       * *
* * * * * *

*/


int main(){
    int x, i, j;

    printf("x ?= ");
    scanf("%d", &x);

    for(j = 0; j < x;printf("* "), ++j);
    printf("\n");
    for(j = 0; j < x - 2; ++j){
        printf("* ");
        for(i = 0; i < j; ++i)
            printf("  ");
        for(; i < x -2; ++i)
            printf("* ");
        printf("*\n");
        }
    for(j = 0; j < x;printf("* "), ++j);
    printf("\n");

    return 0;
    }







