#include <stdio.h>
#include <stdlib.h>

int main(){
    int* * myT;
    unsigned sT1=4, sT2=2, i, j;

    myT = (int**)malloc(sizeof(int*)*sT1);

    for(i = 0; i< sT1; ++i)
        *(myT+i) = (int*)malloc(sizeof(int)*sT2);

    for(i = 0; i< sT1; ++i)
        for(j = 0; j< sT2; ++j)
            *(*(myT+i)+j)=1;


    for(i = 0; i< sT1; ++i){
        for(j = 0; j< sT2; ++j)
            printf("[%d]",*(*(myT+i)+j));
        printf("\n");
        }
    printf("\n\n******************************\n\n");
    for(j = 0; j< sT2; ++j){
        for(i = 0; i< sT1; ++i)
            printf("[%d]",*(*(myT+i)+j));
        printf("\n");
        }


    return 0;
    }

