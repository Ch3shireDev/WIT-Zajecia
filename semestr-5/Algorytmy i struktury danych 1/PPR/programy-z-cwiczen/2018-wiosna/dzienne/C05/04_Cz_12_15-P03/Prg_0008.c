#include <stdio.h>
#include <stdlib.h>

int main(){
    int* myT;

    myT = (int*)malloc(sizeof(int)*4);

    *myT =12;
    *(myT+1) = 9;


    printf("\n%d\n%d\n\n",*myT, *(myT+1));
    return 0;
    }
