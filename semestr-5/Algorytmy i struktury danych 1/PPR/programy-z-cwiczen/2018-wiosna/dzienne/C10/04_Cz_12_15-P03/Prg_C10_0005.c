#include <stdio.h>
#include <stdlib.h>
/*********************************************************/
/*********************************************************/
int MyRead(char*);
/*********************************************************/
/*********************************************************/
int MyRead(char* myStr){
    int x;

    printf("%s", myStr);
    scanf("%d",&x);

    return x;
    }
/*********************************************************/
/*********************************************************/
int main(){
    FILE* myFile;

    myFile = fopen("C:/temp/MyData1.dat","r");
    /**
    r - read
    w - write
    a - append
    */
    if(myFile==NULL){
        printf("There is no file :\"MyData.dat\"");
        return -1;
        }


    return 0;
    }







