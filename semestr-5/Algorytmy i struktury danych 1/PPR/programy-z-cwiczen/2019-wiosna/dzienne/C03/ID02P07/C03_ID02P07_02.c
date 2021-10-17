#include <stdio.h>

int main(){
    int i;
    int x;

    printf("x? = ");
    scanf("%d",&x);

    i = 0;
    for(;i<x;){
        printf("i = %d\n", i);
        ++i;
        }

    return 0;
    }
