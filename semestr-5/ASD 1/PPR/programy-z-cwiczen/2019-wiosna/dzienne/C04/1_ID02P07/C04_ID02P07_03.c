#include <stdio.h>

int main(){
    int* x, *y, *max;

    x = (int*)malloc(sizeof(int)*2);

    *x = 2;
    ++x;
    *x =3;
    --x;
    printf("x = %d\n", *x);
    ++x;
    printf("x = %d\n", *x);


    return 0;
    }
