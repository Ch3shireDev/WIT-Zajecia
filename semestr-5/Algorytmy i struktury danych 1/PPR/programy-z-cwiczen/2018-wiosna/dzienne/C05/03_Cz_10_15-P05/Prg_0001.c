#include <stdio.h>


int main(){
    int x;
    int * px;

    px = &x;

    *px = 12;
    printf("x = %d\n", *px);


    return 0;
    }
