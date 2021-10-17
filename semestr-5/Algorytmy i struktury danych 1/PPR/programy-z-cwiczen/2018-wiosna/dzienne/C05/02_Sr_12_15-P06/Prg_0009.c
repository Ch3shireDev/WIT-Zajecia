#include <stdio.h>
#include <stdlib.h>


int main() {
    int * myT;
    int sizeT;
    int i;

    printf("size ?= ");
    scanf("%d", &sizeT);

    myT = (int*)malloc(sizeof(int)*sizeT);

    for(i = 0; i < sizeT; ++i)
        myT[i] = i;

    for(i = 0; i < sizeT; ++i)
        printf("T[%d] = %d\n",i , *(myT + i));

    /**  t[i] <=> *(t+i) <=> *(i+t <=>) i[t]  */

    printf("\n0[T]=%d\n", 0[myT]);

    return 0;
}
