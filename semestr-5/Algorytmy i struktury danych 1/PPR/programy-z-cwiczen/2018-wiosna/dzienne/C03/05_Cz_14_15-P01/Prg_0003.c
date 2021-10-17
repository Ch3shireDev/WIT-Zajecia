#include <stdio.h>

int main(){
    int x;
    int i;
    int oldX;

    printf("x ?=");
    scanf("%d", &x);

    oldX = x;
    i = x++;
    printf("i = x++ ->i = %d, x = %d\n", i, x);
    x = oldX;
    i = ++x;
    printf("i = ++x ->i = %d, x = %d\n", i, x);

    return 0;
    }
