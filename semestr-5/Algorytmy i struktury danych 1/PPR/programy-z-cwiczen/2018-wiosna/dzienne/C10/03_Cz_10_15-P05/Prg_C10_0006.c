#include <stdio.h>
#include <stdlib.h>
/*********************************************************/
/*********************************************************/
int MyRead(char * myStr);
/**int CountNumbers(char*);*/
/*********************************************************/
/*********************************************************/
int MyRead(char* myStr){
    int x;
    printf("%s", myStr);
    fscanf(stdin,"%d", &x);

    return x;
    }

/*********************************************************/
/*********************************************************/
int main(){
    FILE* myFile;
    char * myStr ="MyData.dat";
    int x;
    int i,f;
    myFile=fopen(myStr,"r");

    if(myFile == NULL){
        printf("There is no file: MyData.dat\n");
        return -1;
        }

    for(i=0;i<12;++i){
        f=fscanf(myFile,"%d", &x);
        printf("x = %d\tf = %d\n************\n",x,f);
        }

    fclose(myFile);
    return 0;
    }
