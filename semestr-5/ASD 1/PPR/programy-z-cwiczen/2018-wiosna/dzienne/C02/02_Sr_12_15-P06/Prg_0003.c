#include <stdio.h>

int main(){
    int x;

    printf("x ?= ");
    scanf("%d", &x);


    if(x > 0 && x < 10){
        printf("\n\t%d  i n (0, 10)\n",x);
        }
    else{
        printf("\n\t%d  <= 0 or %d >= 10\n",x, x);
        }


    printf("\nT H E   E N D\n");
    printf("press any key but RESET or POWER\n");

    return 0;
    }
