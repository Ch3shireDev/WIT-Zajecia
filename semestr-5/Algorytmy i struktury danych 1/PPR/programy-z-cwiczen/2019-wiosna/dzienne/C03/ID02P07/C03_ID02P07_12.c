#include <stdio.h>

int main(){
    int i, j;
    int x;

    printf("x? = ");
    scanf("%d",&x);

    for(j = 0; j<x-1;++j,printf("\n")){
        for(i=0;i<x-1-j;++i,printf("  "));
        for(;i<x;++i,printf(" *"));
        }
    for(i=0;i<2*x-1;++i,printf(" *"));
    printf("\n");

    for(j = 0; j<x-1;++j,printf("\n")){
        for(i=0;i<x-1;++i,printf("  "));
        for(i=0;i<x-j-1;++i,printf(" *"));
        }


    return 0;
    }

/** 2
x? = 5
         *
       * *
     * * *
   * * * *
 * * * * * * * * *
         * * * *
         * * *
         * *
         *

*/
