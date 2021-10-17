#include <stdio.h>
#include <stdlib.h>

int main(){
    int* myFib;
    int i, n;

    printf("n? = ");
    scanf("%d", &n);
    if(n>0){
        myFib = (int*)malloc(sizeof(int)*n);
        myFib[0]=1;
        if(n>1){
            myFib[1]=1;
            for(i=2; i<n;++i){
                myFib[i] = myFib[i-1]+myFib[i-2];
                }
            }
     }
    for(i=0; i<n;++i)
        printf("fib(%2d) = %3d\n",i+1,myFib[i]);

    return 0;
    }


