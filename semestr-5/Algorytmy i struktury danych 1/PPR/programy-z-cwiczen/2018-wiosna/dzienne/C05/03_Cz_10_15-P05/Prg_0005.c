#include <stdio.h>
#include <stdlib.h>

int main(){
    int * px;
    int x;
    char z = ' ';

    x = z;
    z = z + ' ';

    printf("x = %d\n", x);
    printf("z(%d) = %c\n", (int)z, z);

    px = malloc(sizeof(int));
    *px = 12;
    printf("x = %d\n", *px);

    return 0;
    }
