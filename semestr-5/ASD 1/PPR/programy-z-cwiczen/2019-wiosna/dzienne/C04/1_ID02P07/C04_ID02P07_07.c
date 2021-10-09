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

    /**  if(myTab = NULL ) return -1;  */

    for(i=0; i<sizeTab;++i)
        myTab[i] = i;

    for(i=0; i<sizeTab;++i)
        printf("%d\n",myTab[i]);

    /**  myTab[i]   <=>  *(myTab+i)  <=>  *(i+myTab)  <=>  i[myTab]       */

    2[myTab] = 144;

    for(i=0; i<sizeTab;++i)
        printf("%d\n",myTab[i]);

    return 0;
    }
