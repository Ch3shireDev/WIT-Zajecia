#include <stdio.h>
#include <stdlib.h>


int main(){
    int x;
    int* px;


    /** px = &x; */


    printf("size of char\t = %d\n", sizeof(char));
    printf("size of int\t = %d\n", sizeof(int));
    printf("size of double\t = %d\n", sizeof(double));

    px = malloc(4);


    *px =12;
    printf("x = %d\n", *px);


    return 0;
    }
