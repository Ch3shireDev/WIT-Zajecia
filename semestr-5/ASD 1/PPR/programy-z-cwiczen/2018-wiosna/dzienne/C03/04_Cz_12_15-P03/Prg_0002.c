#include <stdio.h>

int main(){
    int x;
    int i;

    printf("x? = ");
    scanf("%d", &x);

    i = 3;
    while(i <= x ){
        printf("i = %d\n",i);
        i = i + 3;
        }


    return 0;
    }
