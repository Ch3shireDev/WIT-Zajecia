#include <stdio.h>
#include <stdlib.h>
/**************************************************************/
/**************************************************************/

/**************************************************************/
/**************************************************************/
int main(){
    FILE* sourceFile,* targetFile;
    char* fileName="MyData.csv";
    int i, x, f;
    sourceFile = fopen(fileName,"r");

    /**
    r - read
    w - write
    a - append
    */
    if(NULL == sourceFile){
        printf("There is no file : %s\n",fileName);
        return -1;
        }
    targetFile=fopen("Target.txt","w");

    for(i=0;i<11;++i){
        /*
        scanf("%d",&x);
        fscanf(stdin,"%d",&x);
        */
        f=fscanf(sourceFile,"%d",&x);
        fprintf(targetFile,"f = %d, x = %d\n",f,x);
        fprintf(stdout,"f = %d, x = %d\n",f,x);
        }


    fclose(sourceFile);
    return 0;
    }
