#include <stdio.h>


int main(){
    int x, i;

    printf(" x?= ");
    scanf("%d", &x);

    i = 0 ;
    while(i < x){
        printf("i = %d\n", i);
        ++i;
        }

    i = 0;
    for(;i < x; ){
        printf("i = %d\n", i);
        ++i;
        }


    for(i = 0;i < x; ++i){
        printf("i = %d\n", i);
        }



    return 0;
    }
