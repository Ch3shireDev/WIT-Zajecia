#include <stdio.h>
#include <stdlib.h>

int main(){
    int* x;
    int i;

    x = (int*)malloc(sizeof(int)*3);

    for(i=0;i<3;++i)
        *(x + i) = i;

    for(i=0;i<3;++i)
        printf("*(x + %d) = %d\n", i, *(x+i));


    return 0;
    }

