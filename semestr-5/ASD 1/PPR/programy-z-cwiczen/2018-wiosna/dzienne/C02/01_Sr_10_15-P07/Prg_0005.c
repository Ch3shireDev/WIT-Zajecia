#include <stdio.h>

int main(){
    int x;
    int *px;

    px=&x;

    printf("x?=");
    scanf("%d",px);



    if(x>0){
        printf("%d Dodatnie\n", *x);
        }
    else{
        printf("%d Niedodatnie\n", *px);
        }




    printf("\nT H E   E N D\n");
    printf("press any key but RESET or POWER\n");

    return 0;
    }
