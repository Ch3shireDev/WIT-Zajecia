#include <stdio.h>
int main(){
    int i, j;
    int x;

    printf("x? = ");
    scanf("%d",&x);


    for(j=0 ; j<x ; ++j,printf(" *"));
    printf("\n");

    for(j=0; j<x-2 ; ++j,printf(" *\n")){
        printf(" *");
        for(i=0; i<x-2 ; ++i,printf("  "));
        }

    for(j=0 ; j<x ; ++j,printf(" *"));
    printf("\n");


    return 0;
    }
/** 2, 3

x? = 5
 * * * * *
 *       *
 *       *
 *       *
 * * * * *

*/



