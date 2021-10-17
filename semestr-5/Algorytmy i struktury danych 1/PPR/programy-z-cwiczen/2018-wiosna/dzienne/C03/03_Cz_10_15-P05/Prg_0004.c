#include <stdio.h>

int main(){
    int n;
    int i;
    int silnia;

    printf("n?= ");
    scanf("%d", &n);

    i = 2;
    silnia = 1;
    while(i<=n){
        silnia = silnia * i;
        ++i;
        }



    printf("%d! = %d\n", n, silnia  );


    return 0;
    }
