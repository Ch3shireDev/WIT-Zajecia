#include <stdio.h>
#include <stdlib.h>

int main(){
    int* x;
    int i;

    x = (int*)malloc(sizeof(int)*3);

    i = 0;
    *(x + i) = 12;
    ++i;
    *(x + i) = 9;
    ++i;
    *(x + i) = 78;

    i=0;
    printf("x = %d\n", *(x+i));
    ++i;
    printf("y = %d\n", *(x+i));
    ++i;
    printf("z = %d\n", *(x+i));


    return 0;
    }

