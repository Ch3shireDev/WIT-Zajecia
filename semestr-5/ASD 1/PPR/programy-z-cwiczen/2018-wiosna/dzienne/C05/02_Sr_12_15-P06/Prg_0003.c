#include <stdio.h>
#include <stdlib.h>


int main(){
    int x;
    int * px;

    /**px = &x;*/

    x = sizeof(int);

    px = malloc(4);

    *px = 12;

    printf("x = %d\n", x);


    return 0;
    }
