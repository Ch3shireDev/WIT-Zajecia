#include <stdio.h>
#include <stdlib.h>


int main() {
    int * myT;
    int sizeT;
    int i;
    int imax;

    printf("size ?= ");
    scanf("%d", &sizeT);

    myT = (int*)malloc(sizeof(int)*sizeT);

    for(i = 0; i < sizeT; ++i){
        printf("T[%2d] ?=", i);
        scanf("%d",&myT[i]); /**scanf("%d",myT+i); */
        }

    for(i=1, imax=0;i<sizeT; ++i)
        if (myT[imax]<=myT[i]) imax=i;

    for(i = 0; i < sizeT; ++i)
        printf("T[%2d] = %3d\n",i , *(myT + i));


    printf("\n\n\tMax[%d] = %d\n",imax , myT[imax]);



    return 0;
}
