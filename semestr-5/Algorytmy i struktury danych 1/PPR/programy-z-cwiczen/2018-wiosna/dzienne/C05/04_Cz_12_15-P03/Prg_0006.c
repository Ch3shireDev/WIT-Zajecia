#include <stdio.h>
#include <stdlib.h>


int main(){
    int* px;

    px = (int*)malloc(sizeof(int)); /**  malloc zwraca (void*) */

    *px = 12;
    printf("x = %d\n", *px);


    return 0;
    }
