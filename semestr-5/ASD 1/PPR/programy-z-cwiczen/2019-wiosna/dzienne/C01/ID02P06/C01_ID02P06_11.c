#include <stdio.h>

int main(){
    int x;
    int myAbs;

    printf("x? = ");
    scanf("%d", &x);

    myAbs = x;

    if(myAbs<0){
        myAbs = -myAbs;
        }

    printf("|%d| = %d\n",x, myAbs);

    return 0;
    }
/**
x? = 11
|11| = 11


x? = -5
|-5| = 5


3, 4, 5

*/



