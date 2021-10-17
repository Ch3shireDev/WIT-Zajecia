#include <stdio.h>
/** 6 +1, 7 + 2, 8 + 3
x ?= 6
                    *
                  * *
                * * *
              * * * *
            * * * * *
          * * * * * *
        * * *       *
      * * * * *     *
    * * * * * * *   *
  * * * * * * * * * *
* * * * * * * * * * *

_ _ _ _ _ + + + + + *
_ _ _ _ _ + + + + * *
_ _ _ _ _ + + + * * *
_ _ _ _ _ + + * * * *
_ _ _ _ _ + * * * * *
_ _ _ _ _ * * * * * *
+ + + + o X o       X
+ + + o o X o o     X
+ + o o o X o o o   X
+ o o o o X o o o o X
* * * * * * * * * * *





*/
int main(){
    int x, i, j;

    printf("x ?= ");
    scanf("%d", &x);

    for(j = 0; j< x-1; ++j){
        for(i = 0; i<x-1-j; ++i)
            printf("  ");
        for(; i<x; ++i)
            printf("* ");
        printf("\n");
        }

    for(i = 0; i < 2*x-1; ++i)
        printf("* ");
    printf("\n");

    for(j = 0; j< x-1; ++j){
        for(i = 0; i<x + j; ++i)
            printf("  ");
        for(i=0; i<x-1-j;++i)
            printf("* ");
        printf("\n");
        }
    return 0;
    }







