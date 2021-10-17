#include <stdio.h>
int main(){
    int i, j;
    int x;

    printf("x? = ");
    scanf("%d",&x);

    for(j=0 ; j<x ; ++j,printf(" *"));
    for(j=0,printf("\n"); j<x-2 ; ++j,printf(" *\n"))
        for(i=0,printf(" *"); i<x-2 ; ++i,printf("  "));
    for(j=0 ; j<x ; ++j,printf(" *"));

    return 0;
    }
/**

x? = 5
 * * * * *
 *       *
 *       *
 *       *
 * * * * *

*/



