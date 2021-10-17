#include <stdio.h>
int main(){
    int x;
    int i;
    int y;

    printf("x? = ");
    scanf("%d",&y);

    x = i = 0;
    while(i<=y){
        printf("%d -> %d\n",i,x);
        x+=++i;
        }

    return 0;
    }
/** 2
0 -> 0
1 -> 1
2 -> 3
3 -> 6
4 -> 10
5 -> 15
6 -> 21
*/
