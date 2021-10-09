#include <stdio.h>
int main(){
    int x;
    int i;

    i = 0;
/*
    printf("x? = ");
    scanf("%d",&x);
*/
    i=0;
    ++i;
    printf("i = %d\n",i);

    i=0;
    i++;
    printf("i = %d\n",i);

    i=0;
    x=++i;
    printf("i = %d\tx = %d\n",i,x);

    i=0;
    x=i++;
    printf("i = %d\tx = %d\n",i,x);

    if(2==x){
    }


    return 0;
    }
