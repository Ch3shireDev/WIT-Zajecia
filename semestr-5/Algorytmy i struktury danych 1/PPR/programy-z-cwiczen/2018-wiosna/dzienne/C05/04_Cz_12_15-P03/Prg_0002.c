#include <stdio.h>
#include <stdlib.h>


int main(){
    /** int x; */
    int* px;

    /** px = &x;*/

    px = malloc(4);

    *px = 12;
    printf("x = %d\n", *px);


    return 0;
    }
