#include <stdio.h>
#include <stdlib.h>

int main(){
    int* x;
    int i;
    int sT = 12;
    x = (int*)malloc(sizeof(int)*sT);

    for(i=0;i<sT;++i)
        x[i] = i;
        ///*(x + i) <=> x[i]

    /// x[i] <=> *(x + i) <=>  *(i + x) <=> i[x]
    1[x] = 123;

    for(i=0;i<sT;++i)
        printf("x[%d] = %d\n", i, x[i]);

    free(x);
/**
    for(i=0;i<sT;++i)
        printf("x[%d] = %d\n", i, x[i]);
*/

    return 0;
    }

