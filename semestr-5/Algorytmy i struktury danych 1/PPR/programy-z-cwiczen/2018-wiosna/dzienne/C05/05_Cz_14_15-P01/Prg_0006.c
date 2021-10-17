#include <stdio.h>
#include <stdlib.h>


int main(){
    int* px;
    char z;

    px = malloc(sizeof(int)); /** malloc zwraca (void*) */

    z = ' ' + ' ';

    printf("z = %c\n",z);

    *px =12;
    printf("x = %d\n", *px);


    return 0;
    }
