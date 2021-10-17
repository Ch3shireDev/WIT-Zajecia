#include <stdio.h>

int main(){
    int x, y;
    int *px, *py;

    px = &x;
    py = &y;

    printf("x?= ");
    scanf("%d", px);

    printf("y?= ");
    scanf("%d", py);

    printf("\n\t%d * %d = %d\n", *px, *py, *px**py);


    printf("\n\tT H E    E N D\n");

    return 0;
    }
