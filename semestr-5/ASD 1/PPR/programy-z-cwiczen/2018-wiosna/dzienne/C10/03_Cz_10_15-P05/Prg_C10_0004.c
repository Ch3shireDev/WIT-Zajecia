#include <stdio.h>
#include <stdlib.h>
/*********************************************************/
/*********************************************************/
int MyRead(char * myStr);
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
    int x;

    x= MyRead("test fscanf :");
    myFile=fopen("MyData.dat","r");
    /**
    r - read
    w - write
    a - append
    */

    if(myFile == NULL){
        printf("There is no file: MyData.dat\n");
        return -1;
        }



    return 0;
    }
