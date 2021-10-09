#include <stdio.h>
#include <stdlib.h>

int main(){
    int* x;
    int i;
    int sT = 3;
    x = (int*)malloc(sizeof(int)*sT);

    for(i=0;i<sT;++i)
        *(x + i) = i;

    for(i=0;i<sT;++i)
        printf("*(x + %d) = %d\n", i, *(x+i));


    return 0;
    }

