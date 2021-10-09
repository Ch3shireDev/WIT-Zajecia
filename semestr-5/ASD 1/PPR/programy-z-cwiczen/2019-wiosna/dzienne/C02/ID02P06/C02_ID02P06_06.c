#include <stdio.h>

int main(){
    int x;
    int i;
    /*
    printf("x? = ");
    scanf("%d", &x);
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


    return 0;
    }
