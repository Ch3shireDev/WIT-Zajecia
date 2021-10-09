#include <stdio.h>
#include <stdlib.h>


int main(){
    int *t, i, j;

    for(i=0; i<999900000;++i){
        t=(int*)malloc(sizeof(int)*999999999);
        free(t);
    }

    return 0;
    }
