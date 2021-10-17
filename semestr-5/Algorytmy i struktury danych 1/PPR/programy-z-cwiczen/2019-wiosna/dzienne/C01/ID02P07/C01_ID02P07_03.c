#include <stdio.h>

int main(){
    int x;
    int* px;

    x = 12;
    px = &x;

    printf("x = %d\n",x);
    printf("x = %d\n",*px);
    *px = 27;

    printf("x = %d\n",x);
    printf("x = %d\n",*px);

    printf("x? = ");
    scanf("%d", &x);
    printf("x = %d\n",x);

    return 0;
    }
