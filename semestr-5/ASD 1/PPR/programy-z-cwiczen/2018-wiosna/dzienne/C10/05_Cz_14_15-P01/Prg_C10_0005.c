#include <stdio.h>
#include <stdlib.h>
/*********************************************************/
/*********************************************************/
int MyRead(char*);
/*********************************************************/
/*********************************************************/
int MyRead(char* myStr){
    int x;
    printf("%s",myStr);
    scanf("%d", &x);

    return x;
    }
/*********************************************************/
/*********************************************************/
int main(){
    FILE* myFile;
    char* fileName="MyData.dat";
    char* fileName2="c:/temp/MyData1.dat";

    myFile = fopen(fileName2,"r");

    /**
    r - read
    w - write
    a - append
    */

    if(myFile==NULL){
        printf("There is no file: \"%s\"\n",fileName);
        return -1;
        }

    return 0;
    }







