#include <stdio.h>
#include <stdlib.h>

int main(){
    int* myTab;
    int sizeTab;
    int i;

    printf("size? = ");
    scanf("%d", &sizeTab);

    myTab = (int*)malloc(sizeof(int)*sizeTab);

    if(NULL == myTab) return -1;

    if(sizeTab>0){
        myTab[0] = 1;
        if(sizeTab>1){
            myTab[1] = 1;
            for(i=2; i<sizeTab;++i)
                myTab[i] = myTab[i-1]+myTab[i-2];
            }
        }
    for(i=0; i<sizeTab;++i)
        printf("fib(%2d) = %3d\n",i+1,myTab[i]);


    free(myTab);

    return 0;
    }

/**2

n? = 10

1
1
2
3
5
8
13
21
34
55





*/
