#include <stdio.h>
/**

x ?= 4
* * * * * * * * * *
  * * *     * * *
    * *     * *
      * * * *
*/
int main(){
    int x, i, j;

    printf("x ?= ");
    scanf("%d", &x);

    for(i=0; i<3*x-2;++i)
        printf("* ");
    printf("\n");

    for(j=1; j<x-1;++j){
        for(i=0; i<j; ++i)
            printf("  ");
        for( ; i<x; ++i)
            printf("* ");
        for(i=0; i<x-2; ++i)
            printf("  ");

        for(i=0 ; i<x-j; ++i)
            printf("* ");
        printf("\n");
        }

    for(i=0; i<x-1;++i)
        printf("  ");
    for(i=0; i<x;++i)
        printf("* ");
    printf("\n");

    return 0;
    }







