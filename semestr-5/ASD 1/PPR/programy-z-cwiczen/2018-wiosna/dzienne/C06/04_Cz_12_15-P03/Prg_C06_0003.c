#include <stdio.h>
#include <stdlib.h>

int main(){
    int* *myT;
    unsigned sT1=4, sT2=2, i, j;


    myT = (int**)malloc(sizeof(int*)*sT1);

    *(myT+0) = (int*)malloc(sizeof(int)*sT2);
    *(myT+1) = (int*)malloc(sizeof(int)*sT2);
    *(myT+2) = (int*)malloc(sizeof(int)*sT2);
    *(myT+3) = (int*)malloc(sizeof(int)*sT2);

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
