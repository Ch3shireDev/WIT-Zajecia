#include <stdio.h>

int main(){
    int x0, y0, z0;
    int x1, y1, z1;
    int tmp;

    printf("x ?= ");
    scanf("%d", &x0);
    printf("y ?= ");
    scanf("%d", &y0);
    printf("z ?= ");
    scanf("%d", &z0);

    x1 = x0;
    y1 = y0;
    z1 = z0;

    if( x1> y1){
        tmp = x1;
        x1 = y1;
        y1 = tmp;
        }

    if( y1> z1){
        tmp = z1;
        z1 = y1;
        y1 = tmp;
        }

    if( x1> y1){
        tmp = x1;
        x1 = y1;
        y1 = tmp;
        }

    printf("(%d, %d, %d) -> (%d, %d, %d)",x0 ,y0, z0, x1, y1, z1);

    printf("\nT H E   E N D\n");
    printf("press any key but RESET or POWER\n");

    return 0;
    }
