#include <stdio.h>
#include <stdlib.h>


int main(){
    int* px;
    int x = 111111;
    char z;

    z =(char)x;
    x =(int)z;

    printf("x = %d\n", x);

    z ='a';
    printf("z = %c\n", z);

    z =' ';
    printf("z(%d) = %c\n", (int)z, z);

    z =' ' + ' ';
    printf("z(%d) = %c\n", (int)z, z);

    px = malloc(sizeof(int));



    *px = 12;
    printf("x = %d\n", *px);


    return 0;
    }
