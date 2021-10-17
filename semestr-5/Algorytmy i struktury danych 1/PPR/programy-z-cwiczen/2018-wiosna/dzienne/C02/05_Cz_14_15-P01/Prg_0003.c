#include <stdio.h>

int main(){
    int x, y;

    printf("x?= ");
    scanf("%d", &x);

    y = x;

    if(y < 0){
        y = -y;
        }

    printf("\n\t|%d| = %d\n",x, y);


    printf("\n\tT H E    E N D\n");

    return 0;
    }
