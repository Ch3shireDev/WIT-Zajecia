#include <stdio.h>

int main(){
    int* x, *y, *max;

    x = (int*)malloc(sizeof(int)*2);

    *x = 2;
    ++x;
    *x =3;
    --x;
    printf("x = %d\n", *x);
    y=++x;
    printf("x = %d\n", *x);
    --x;

    printf("\tx = %d\n", *x);
    printf("\ty = %d\n", *y);
    return 0;
    }
