#include <stdio.h>


int main(){
    int x, y, i, j;

    printf(" x?= ");
    scanf("%d", &x);


    for(j = 0; j < x; ++j){
        for(i = 0;i < j; ++i){
            printf("  ");
            }
        for( ;i < x ; ++i){
            printf(" *");
            }
        printf("\n");
        }


    return 0;
    }
