#include <stdio.h>
#include <stdlib.h>

int main(){
    int* x;

    x = (int*)malloc(sizeof(int)*3);
    *x =12;

    printf("x = %d\n", *x);


    *(x + 1) = 9;
    *(x + 2) = 78;

    printf("y = %d\n", *(x+1));
    printf("z = %d\n", *(x+2));

    return 0;
    }

