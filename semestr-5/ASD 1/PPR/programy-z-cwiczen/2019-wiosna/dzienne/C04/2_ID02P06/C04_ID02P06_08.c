#include <stdio.h>
#include <stdlib.h>

int main(){
    int* x;
    int i;

    x = (int*)malloc(sizeof(int)*3);

    i = 0;
    *(x + 0) = 12;
    *(x + 1) = 9;
    *(x + 2) = 78;

    printf("x = %d\n", *(x+0));
    printf("y = %d\n", *(x+1));
    printf("z = %d\n", *(x+2));

    return 0;
    }

