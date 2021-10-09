#include <stdio.h>

int main(){
    int x;
    int* px;

    px = &x;

    printf("x? = ");
    scanf("%d", &x);
    printf("x = %d\n",x);

    printf("x? = ");
    scanf("%d", px);
    printf("x = %d\n",x);

    return 0;
    }
