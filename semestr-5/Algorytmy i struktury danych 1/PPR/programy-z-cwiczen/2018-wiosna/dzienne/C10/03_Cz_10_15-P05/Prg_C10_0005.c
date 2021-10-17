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
    myFile=fopen("MyData.dat","r");

    if(myFile == NULL){
        printf("There is no file: MyData.dat\n");
        return -1;
        }
    printf("scanf: x ?=");
    scanf("%d", &x);
    printf("x = %d\n************\n",x);

    printf("fscanf:stdin x ?=");
    fscanf(stdin,"%d", &x);
    printf("x = %d\n************\n",x);

    printf("fscanf:file x ?=");
    fscanf(myFile,"%d", &x);
    printf("x = %d\n************\n",x);


    return 0;
    }
