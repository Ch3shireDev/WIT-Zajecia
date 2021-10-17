#include <stdio.h>

int main(){
    int* x, *y, *max;

    x = (int*)malloc(sizeof(int));
    y = (int*)malloc(sizeof(int));

    printf("x? = ");
    scanf("%d", x);
    printf("y? = ");
    scanf("%d", y);

    max = y;

    if(*x>*max) max = x;

    /**

    if(*x>*y) max = x;
    else max =y;

    */

    printf("max = %d\n", *max);
    return 0;
    }
/** 1, 2, 3  */
