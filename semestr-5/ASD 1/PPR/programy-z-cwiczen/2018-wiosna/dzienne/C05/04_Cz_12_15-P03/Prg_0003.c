#include <stdio.h>
#include <stdlib.h>


int main(){
    int* px;
    int st;

    st = sizeof(int);
    printf("size of int = %d\n", sizeof(int));
    st = sizeof(char);
    printf("size of char = %d\n", sizeof(char));
    st = sizeof(double);
    printf("size of double = %d\n", sizeof(double));

    px = malloc(4);



    *px = 12;
    printf("x = %d\n", *px);


    return 0;
    }
