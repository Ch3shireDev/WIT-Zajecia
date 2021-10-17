#include <stdio.h>

int main(){
    int x;
    int i;

    printf("x ?=");
    scanf("%d", &x);

    i = 60;
    while(i <= x){
        printf("i = %d\n", i);
        i = i + 60;
        }


    return 0;
    }
