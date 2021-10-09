#include <stdio.h>
#include <stdlib.h>

int main(){
    int * px;
    int ps;

    ps = sizeof(int);

    printf("size of int = %d\n", ps);

    px = malloc(4);

    *px = 12;
    printf("x = %d\n", *px);


    return 0;
    }
