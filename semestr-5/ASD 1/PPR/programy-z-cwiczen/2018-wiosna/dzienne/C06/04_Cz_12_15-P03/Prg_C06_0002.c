#include <stdio.h>
#include <stdlib.h>

int main(){
    int* *myT;
    int *t0, *t1, *t2, *t3;
    unsigned sT1=4, sT2=2, i, j;


    myT = (int**)malloc(sizeof(int*)*sT1);

    t0 = (int*)malloc(sizeof(int)*sT2);
    t1 = (int*)malloc(sizeof(int)*sT2);
    t2 = (int*)malloc(sizeof(int)*sT2);
    t3 = (int*)malloc(sizeof(int)*sT2);

    *(myT+0) = t0;
    *(myT+1) = t1;
    *(myT+2) = t2;
    *(myT+3) = t3;

   for(i=0;i<sT1; ++i)
        for(j=0;j<sT2;++j)
    *(*(myT+i)+j) = 1;


    for(i=0;i<sT1; ++i){
        for(j=0;j<sT2;++j)
            printf("[%2d]",*(*(myT+i)+j));
        printf("\n");
        }


    return 0;
    }
