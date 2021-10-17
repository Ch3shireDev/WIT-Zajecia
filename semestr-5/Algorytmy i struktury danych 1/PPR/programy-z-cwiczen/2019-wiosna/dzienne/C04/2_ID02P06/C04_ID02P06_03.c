#include <stdio.h>
#include <stdlib.h>

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

    printf("max(%d, %d) = %d\n", *x, *y, *max);


    return 0;
    }

