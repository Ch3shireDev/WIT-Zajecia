#include <stdio.h>
#include <stdlib.h>
/*********************************************************/
/*********************************************************/
int MyRead(char*);
/*********************************************************/
/*********************************************************/
int MyRead(char* myStr){
    int x;
    fprintf(stdout,"%s",myStr);
    fscanf(stdin,"%d", &x);

    return x;
    }
/*********************************************************/
/*********************************************************/
int main(){
    FILE* myFile;
    int x;
    char* fileName="MyData.dat";
    char* fileName2="c:/temp/MyData1.dat";

    myFile = fopen(fileName2,"r");

    if(myFile==NULL){
        printf("There is no file: \"%s\"\n",fileName);
        return -1;
        }


    fscanf(myFile,"%d",&x);
    printf("x = %d\n",x);
    fscanf(myFile,"%d",&x);
    printf("x = %d\n",x);

    return 0;
    }







