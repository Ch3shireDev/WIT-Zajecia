#include<stdio.h>


int main(){
    int x;
    int i;

    printf("x?= ");
    scanf("%d", &x);

    i=++x;
    printf("i = ++x -> x=%d, i=%d\n",x,i);
    i=x++;
    printf("i = x++ -> x=%d, i=%d\n",x,i);



    return 0;
    }
