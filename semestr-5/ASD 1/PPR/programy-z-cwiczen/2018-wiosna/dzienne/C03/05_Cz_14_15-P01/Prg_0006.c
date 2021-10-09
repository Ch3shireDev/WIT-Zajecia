#include <stdio.h>

int main(){
    int n;
    int i;
    int fib3, fib2, fib1;

    printf("n ?=");
    scanf("%d", &n);

    fib3 = fib2 = fib1 = 1;

    i = 3;
    while(i<=n){
        fib3 = fib2 +fib1;
        fib1 = fib2;
        fib2 = fib3;

        ++i;
        }


    printf("fib(%d) = %d\n", n, fib3);

    return 0;
    }
