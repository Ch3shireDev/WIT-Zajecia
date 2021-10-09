#include <stdio.h>

int main(){
    int x, y;

    printf("x ?= ");
    scanf("%d", &x);

    y = x;

    if(y < 0){
        y=-y;
        }

    printf("\n\t|%d| = %d\n",x, y);

    printf("\nT H E   E N D\n");
    printf("press any key but RESET or POWER\n");

    return 0;
    }
