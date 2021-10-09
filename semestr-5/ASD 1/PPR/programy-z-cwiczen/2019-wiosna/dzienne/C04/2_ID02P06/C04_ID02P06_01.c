#include <stdio.h>
#include <stdlib.h>

int main(){
    int x;
    int* px;

    px =&x;

    printf("sizeof(int) = %d\n", sizeof(int));

    px =   malloc(sizeof(int));



    return 0;
    }
