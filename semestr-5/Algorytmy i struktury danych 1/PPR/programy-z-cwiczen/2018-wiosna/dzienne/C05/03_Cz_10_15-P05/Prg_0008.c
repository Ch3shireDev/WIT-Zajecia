#include <stdio.h>
#include <stdlib.h>

int main(){
    int * myT;

    myT = (int*)malloc(sizeof(int)*4);

    *myT = 12;
    *(myT+1) = 7;
printf("*myT = %d\n*(myT+1)= %d", myT, (myT+1));
    return 0;
    }
