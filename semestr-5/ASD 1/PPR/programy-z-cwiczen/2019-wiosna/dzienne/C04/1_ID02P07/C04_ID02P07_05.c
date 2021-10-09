#include <stdio.h>
#include <stdlib.h>

int main(){
    int* myTab;
    int sizeTab;
    int i;

    printf("size? = ");
    scanf("%d", &sizeTab);

    myTab = (int*)malloc(sizeof(int)*sizeTab);
    /**  ++myTab  <=> myTab = myTab+1 */
    /**  myTab + 0 */
    /**  myTab + 1 */
    /**  myTab + 2 */
    /**  ... */
    /**  myTab + i */


    for(i=0; i<sizeTab;++i)
        *(myTab+i) = i;

    for(i=0; i<sizeTab;++i)
        printf("%d\n",*(myTab+i));

    return 0;
    }
