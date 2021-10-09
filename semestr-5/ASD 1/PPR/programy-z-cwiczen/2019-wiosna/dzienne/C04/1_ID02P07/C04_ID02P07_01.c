#include <stdio.h>

int main(){
    int x;
    int* px;
    px = &x;

    printf("sizeof(int) = %d\n",sizeof(int));

    px = (int*)malloc(sizeof(int));


    return 0;
    }
