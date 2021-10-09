#include <stdio.h>
#include <stdlib.h>


int main(){
    int* px;
    int x;
    char z;

    x = 111111;
    z =(char)x;
    x =(int)z;

    printf("x = %d\n",x);


    px = malloc(sizeof(int));

    *px =12;
    printf("x = %d\n", *px);


    return 0;
    }
