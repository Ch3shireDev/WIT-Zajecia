#include <stdio.h>
#include <stdlib.h>

int main(){
    int* px;
    px =(int*)malloc(sizeof(int));

    *px =12;

    printf("rozmiar int = %d\n", sizeof(int));





    return 0;
    }
