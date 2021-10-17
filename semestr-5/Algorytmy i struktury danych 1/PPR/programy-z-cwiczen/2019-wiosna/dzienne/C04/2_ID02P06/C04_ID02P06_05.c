#include <stdio.h>
#include <stdlib.h>

int main(){
    int* x, *y, *z;

    x = (int*)malloc(sizeof(int)*3);
    *x =12;

    printf("x = %d\n", *x);

    y = x + 1;
    z = x + 2;

    *y = 9;
    *z = 78;

    printf("y = %d\n", *y);
    printf("z = %d\n", *z);

    return 0;
    }

