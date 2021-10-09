#include <stdio.h>
int main(){
    int i, j;
    int x;

    printf("x? = ");
    scanf("%d",&x);


    for(j=0 ; j<x ; ++j,printf("\n"))
        for(i=0 ; i<x-j ; ++i,printf(" *"));


    return 0;
    }
/** 2

x? = 5
 * * * * *
 * * * *
 * * *
 * *
 *

*/



