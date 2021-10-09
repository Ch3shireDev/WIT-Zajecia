#include <stdio.h>

int main(){
    int x;
    int i;
    int suma=0;

    printf("x? = ");
    scanf("%d", &x);

    i=0;
    while(i<=x){
        printf("%d ->  %d\n",i, suma);
        suma+=++i;
        }

    return 0;
    }
/** 2, 3, 4, 5
x? = 6
0 -> 0
1 -> 1
2 -> 3
3 -> 6
4 -> 10
5 -> 15
6 -> 21



*/
