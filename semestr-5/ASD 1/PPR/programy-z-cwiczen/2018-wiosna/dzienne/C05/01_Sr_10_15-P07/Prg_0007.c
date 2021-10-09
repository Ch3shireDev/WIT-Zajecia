#include <stdio.h>
#include <stdlib.h>

int main(){
    int* myT;
    int size;
    int i;

    printf("x ?= ");
    scanf("%d", &size);

    myT = (int*)malloc(sizeof(int)*size);

    for(i = 0; i< size; ++i){
        myT[i] = i;
        }

    for(i = 0; i< size; ++i){
        printf("t[%2d] = %3d\n", i, myT[i]);
        }


    return 0;
    }
