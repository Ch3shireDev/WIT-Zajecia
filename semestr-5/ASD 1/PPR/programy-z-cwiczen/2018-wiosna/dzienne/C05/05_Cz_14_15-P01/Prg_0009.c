#include <stdio.h>
#include <stdlib.h>

int main(){
    int* myT;

    myT = (int*)malloc(sizeof(int)*4);

    *myT = 12;
    printf("%d\n%d\n", myT, myT+1);


    return 0;
    }




