#include <stdio.h>

int main(){
    int x;
    int i;

    printf("x?= ");
    scanf("%d", &x);

    i=x++;

    ++x;

    x++;


    printf("i=%d\tx=%d\n",i,x);





    return 0;
    }
