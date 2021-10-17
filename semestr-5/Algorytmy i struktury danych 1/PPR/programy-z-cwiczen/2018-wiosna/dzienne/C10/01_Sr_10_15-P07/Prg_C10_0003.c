#include <stdio.h>
#include <stdlib.h>
/**************************************************************/
/**************************************************************/
int main(){
    FILE* myFile, *myTarget;
    int x,i, f;
    myFile = fopen("MyData.csv","r");
    /**
    r - read
    w - write
    a - append
    */

    for(i=0; i<12;++i){
        /**fscanf(stdin, "%d", &x);*/
        f=fscanf(myFile, "%d", &x);
        printf("f=%d, x=%d\n",f,x);
        }
    fclose(myFile);
    myFile = fopen("MyData.csv","r");
    if(myFile==NULL) {
        printf("brak pliku: MyData.csv ");
        return 0;
        }
    myTarget = fopen("MyCopy.txt","w");
    f=fscanf(myFile, "%d", &x);
    printf("\n************************\n");

    while(f==1){
        /**fscanf(stdin, "%d", &x);*/
        printf("f=%d, x=%d\n",f,x);
        fprintf(myTarget,"f=%d, x=%d\n",f,x);
        f=fscanf(myFile, "%d", &x);
        }
    fclose(myTarget);
    fclose(myFile);
    return 0;
    }
