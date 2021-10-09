#include <stdio.h>
int main(){
    int i, j;
    int x;

    printf("x? = ");
    scanf("%d",&x);


    for(i=0 ; i<x ; ++i){
        printf(" *");
        }
    printf("\n\n");

    for(j=0 ; j<x ; ++j){
        printf(" *\n");
        }


    return 0;
    }
/**

x? = 5
 * * * * *

 *
 *
 *
 *
 *

*/
