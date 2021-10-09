#include <stdio.h>

int main(){
    int x;

    printf("x?=");
    scanf("%d",&x);
    printf("\n\tx=%d\n",x);

    if(x>0 && x<10){
        printf("%d in (0, 10)\n",x);
        }



    printf("\nT H E   E N D\n");
    printf("press any key but RESET or POWER\n");

    return 0;
    }
