#include<stdio.h>
#include<stdlib.h>
#include<time.h>


int main(){
    srand(time(NULL));

    int x = rand()%101;
    printf("x = %d\n",x);

    for(int i=0; i<100;++i)
        printf("%d\n", rand()%100);

    return 0;
    }
