#include <stdio.h>

int main(){
    int x;

    printf("x?= ");
    scanf("%d", &x);

    if(x > 0){
        printf("\n\t%d > 0\n",x);
        }
    else{
        printf("\n\t%d <= 0\n",x);
        }



    printf("\n\tT H E    E N D\n");

    return 0;
    }
