#include <stdio.h>
#include <stdlib.h>

int main(){
    int* x;
    int i;

    x = (int*)malloc(sizeof(int)*3);

    i = 0;
    *(x + i) = 0;
    ++i;
    *(x + i) = 1;
    ++i;
    *(x + i) = 2;

    for(i=0;i<3;++i)
        printf("*(x + %d) = %d\n", i, *(x+i));


    return 0;
    }

